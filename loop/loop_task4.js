var x=4;
var y=6;

for(var i=1; i<=x; i++){
    for (var j=1; j<=y; j++){
        if(i==1 || i==x || j==1 || j==y)
        console.log("*");
        else
        console.log("   ");
    }
    console.log( " " )
}

