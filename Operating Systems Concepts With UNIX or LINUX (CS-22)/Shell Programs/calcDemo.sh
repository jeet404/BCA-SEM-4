#!/bin/sh

case $2 in
    +) z=`expr $1 + $3`;;
    -) z=`expr $1 - $3`;;
    /) z=`expr $1 / $3`;;
    x) z=`expr $1 \* $3`;;
    %) z=`expr $1 % $3`;;
    *) echo Warning - $2 invalied operator, only +,-,x,/ operator allowed
esac
echo Answer is $z