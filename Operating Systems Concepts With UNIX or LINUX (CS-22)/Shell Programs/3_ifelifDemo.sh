#!/bin/sh

age=18

if [ $age -eq 18 ]; then
    echo "You are Mature"
elif [ $age -lt 18 ]; then
    echo "You are Minor"
fi
