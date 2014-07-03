#!/usr/bin/env python2
from sys import argv, exit

class Number:
    def __init__(self, i):
        self.i = i
        self.marked = False

def gen_primes(n, p, lst, counter):
    for i in range(p, n, p):
        if lst[counter].i != p:
            #print str(i) + " is marked now"
            lst[counter].marked = True
        counter+=p

    a = 0
    for num in lst:
        if num.i > p and not num.marked:
            counter = a
            gen_primes(n, num.i, lst, counter)
            break
        a += 1


def find_primes(n):
    lst = [Number(i) for i in range(2, n)]
    gen_primes(n, 2, lst, 0)
    print [num.i for num in lst if not num.marked]


if __name__ == "__main__":
    if len(argv) != 2:
        print("Usage: %s <number to find primes up to>" % argv[0])
        exit(1)
    
    find_primes(int(argv[1]))