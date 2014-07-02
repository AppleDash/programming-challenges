#!/usr/bin/env python2
import sys
import socket

def handle_privmsg(config, sock, line, spl):
    sender = spl[0][1:].split("!")[0]  # Parse out the message sender's nick
    target = spl[2]
    message = line[1:].split(":")[1].strip() # Parse out the message; this won't account for colons in the body, but this is quick.
    reply_to = sender
    if target[0] == "#":
        reply_to = target

    if message.lower() == ("hi, %s" % config["me"]["nick"].lower()):
        sock.send("PRIVMSG %s :Hello there, %s!\r\n" % (reply_to, sender))

    if message[0] == "!":
        data = message[1:].split(" ")
        command = data[0].lower()
        args = []
        if len(data) > 1:
            args = data[1:]

        if command == "say":
            if len(args) == 0:
                sock.send("PRIVMSG %s :You need to specify something to say!\r\n")
            else:
                sock.send("PRIVMSG %s :%s\r\n" % (reply_to, " ".join(args)))

        # Add more bot commands here!

def run_bot(config):
    sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    sock.connect((config["server"]["host"], config["server"]["port"]))
    sock.send("NICK %s\r\nUSER python * * :Python\r\n" % config["me"]["nick"])

    for line in sock.makefile("r"):
        line = line.strip()
        print(line)
        spl = line.split(" ")

        if spl[0] == "PING":
            sock.send(line.replace("PING", "PONG") + "\r\n")

        if spl[1] == "376":  # End of MOTD
            sock.send("JOIN %s\r\n" % config["me"]["channel"])
        elif spl[1] == "PRIVMSG":
            handle_privmsg(config, sock, line, spl)

def main(argv):
    if len(argv) < 5:
        print("Usage: %s <IRC server host> <IRC server port> <bot nick> <channel to join>" % argv[0])
        return 1

    config = {
        "server": {
            "host": argv[1],
            "port": int(argv[2])
        },

        "me": {
            "nick": argv[3],
            "channel": argv[4]
        }
    }

    run_bot(config)

    return 0

if __name__ == "__main__":
    sys.exit(main(sys.argv))