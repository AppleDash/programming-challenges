#!/usr/bin/env python2
from sys import argv, exit

if __name__ == "__main__":
    if len(argv) != 2:
        print("Usage: %s <height of tree to generate>" % argv[0])
        exit(1)

    size = int(argv[1])

    maxs = 1 + (size * 2)
    for i in range(0, size):
        this = "*" * (1 + (i * 2))
        real = (" " * (maxs - len(this))) + (" " * (len(this) / 2)) + this
        print real[maxs / 2:]
    print (" " * (maxs / 2)) + "*"