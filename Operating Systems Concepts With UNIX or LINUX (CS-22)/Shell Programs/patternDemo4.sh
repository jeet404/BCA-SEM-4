n=9
n=`expr $n/2`

i=`expr $i-$n`
while [ $i -le $n ]; do
    ii = `expr ${i#-}`
    j=1
    while [ $j -le $ii ]; do
        echo " "
        j=`expr $j+1`
    done
    j=$ii
    while [ $j -le $n ]; do
        if [ $i -lt 0 ]; then
            echo "* "
        elif [ $i -lt 0 ]; then
            echo "- "
        else
            echo "= "
            j=`expr $j+1`
        fi
    done
    echo "\n"
    i=`expr $i+1`
done
