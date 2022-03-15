#/bin/sh

i=1
while [ $i -le 4 ]
do
	j=1
	space=5
	while [ $space -ge $i ]
	do
		echo -n " "
		space=`expr $space - 1`
	done
	while [ $j -le $i ]
	do
		echo -n "* "
		j=`expr $j + 1`
	done
	echo " "
	i=`expr $i + 1`
done

#Reverse
i=1
while [ $i -le 5 ]
do
	j=5
	space=1
	while [ $space -le $i ]
	do
		echo -n " "
		space=`expr $space + 1`
	done
	while [ $j -ge $i ]
	do
		if [ $i -eq 1 ]
		then
			echo -n "= "
		else
			echo -n "- "
		fi
		j=`expr $j - 1`
	done
	echo " "
	i=`expr $i + 1`
done
