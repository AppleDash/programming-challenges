#!/usr/bin/env python2
import sys
import socket





class Bot:
    def __init__(self, host, port, nick, channel):
        self.host = host
        self.port = port
        self.nick = nick
        self.channel = channel
        self.sock = socket.socket(socket.AF_INET, socket.SOCK_STREAM)

    def sendraw(self, data):
        self.sock.send(data + "\r\n")

    def run(self):
        self.sock.connect((self.host, self.port))
        self.sendraw("NICK %s" % self.nick)
        self.sendraw("USER python * * :Python")
    
        for line in self.sock.makefile("r"):
            line = line.strip()
            print("-> " + line)
            spl = line.split(" ")
    
            if spl[0] == "PING":
                self.sendraw(line.replace("PING", "PONG"))
    
            if spl[1] == "376":  # End of MOTD
                self.sendraw("JOIN %s" % self.channel)
            elif spl[1] == "PRIVMSG":
                self.handle_privmsg(line, spl)

    def handle_privmsg(self, line, spl):
        sender = spl[0][1:].split("!")[0]  # Parse out the message sender's nick
        target = spl[2]
        message = line[1:][line[1:].index(":")+1:] # Parse out the message
        print("[%s] <%s> %s" % (target, sender, message))
        reply_to = sender
        if target[0] == "#":
            reply_to = target
    
        if message.lower() == ("hi, %s" % self.nick.lower()):
            self.sendraw("PRIVMSG %s :Hello there, %s!" % (reply_to, sender))
    
        if message[0] == "!":
            data = message[1:].split(" ")
            command = data[0].lower()
            args = []
            if len(data) > 1:
                args = data[1:]
    
            if command == "say":
                if len(args) == 0:
                    self.sendraw("PRIVMSG %s :You need to specify something to say!")
                else:
                    self.sendraw("PRIVMSG %s :%s" % (reply_to, " ".join(args)))
    
            # Add more bot commands here!   

def main(argv):
    if len(argv) < 5:
        print("Usage: %s <IRC server host> <IRC server port> <bot nick> <channel to join>" % argv[0])
        return 1

    b = Bot(argv[1], int(argv[2]), argv[3], argv[4])
    b.run()

    return 0

if __name__ == "__main__":
    sys.exit(main(sys.argv))