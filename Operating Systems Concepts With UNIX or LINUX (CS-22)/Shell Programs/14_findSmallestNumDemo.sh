echo "Enter Age of Ram : "
read ram
echo "Enter Age of Shyam : "
read shyam
echo "Enter Age of Ghanshyam : "
read ghanshyam

if [ $ghanshyam -lt $ram ]; then
    if [ $ghanshyam -lt $shyam ]; then
        echo "Ghanshyam is Youngest."
    else
        echo "Shyam is Youngest."
    fi
elif [ $ghanshyam -eq $shyam ] && [ $ghanshyam -eq $ram ]; then
    echo "They have same Age."
else
    if [ $ram -lt $shyam ]; then
        echo "Ram is Youngest."
    else
        echo "Shyam is Youngest."
    fi
fi