echo "Enter Age of Ram : "
read ram
echo "Enter Age of Shyam : "
read shyam
echo "Enter Age of Ghanshyam : "
read ghanshyam

if [ $ghanshyam -gt $ram ]; then
    if [ $ghanshyam -gt $shyam ]; then
        echo "Ghanshyam is Oldest."
    else
        echo "Shyam is Oldest."
    fi
elif [ $ghanshyam -eq $shyam ] && [ $ghanshyam -eq $ram ]; then
    echo "They have same Age."
else
    if [ $ram -gt $shyam ]; then
        echo "Ram is Oldest."
    else
        echo "Shyam is Oldest."
    fi
fi