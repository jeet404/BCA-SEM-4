#!/bin/sh

res=`expr $1 \* 20 - $2 \* 2 + $3 / $4`
echo "Result of ($1*20-$2*2+$3/$4) : $res"