#!/usr/bin/env php
<?php
	date_default_timezone_set("UTC");
	$running = true;

	function get_time() {
		$data = file_get_contents("http://time.is/t/");
		$spl = explode("\n", $data);
		$time = trim($spl[0]);
		$seconds = substr($time, 0, 10);
		$millis = substr($time, 10);
		return strftime("%T.$millis", $seconds);
	}

	function handle_signal($sig) {
		$running = false;
	}

	function getch_nonblock($timeout) {
    $read = array(STDIN);
    $null = null;    // stream_select() uses references, thus variables are necessary for the first 3 parameters
    if(stream_select($read,$null,$null,floor($timeout / 1000000),$timeout % 1000000) != 1) return null;
    return ncurses_getch();
	}

	ncurses_init();
	while ($running) {
		ncurses_clear();
		ncurses_move(0, 0);
		ncurses_addstr("Current time: " . get_time());
		ncurses_refresh();
		$key = getch_nonblock(1);
		if ($key !== null) {
			$running = false;
		}
		sleep(1);
	}
	ncurses_end();
?>