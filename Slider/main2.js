// pobierz canvas

const canvas = document.querySelector('#slider');
// pobierz kontekst
const ctx = canvas.getContext('2d');
// check
// ctx.fillStyle="red";
// ctx.fillRect(100,100,200,100);

// 1. załaduj grafiki
// 2. animuj grafiki

const imgCount = 5;
const imgWidth = 1200;
const imgArray = []
let offsetX = 0;
for(let i = 1; i<imgCount; i++)
{
    imgArray[i] = new Image();
    imgArray[i].addEventListener('load', function(){
        console.log('image' +  i + 'loaded')
        ctx.draImage(imgArray[i], 0, 0)
    }
    )
    imgArray[i].src = 'img/' + i + '.jpg';

}

function animate()
{
    offsetX--;
    for (let i = 1; (i-1)*imgWidth < imgArray.lengt; i++) 
    {
        // console.log('image' + i + 'draw')
        ctx.drawImage(imgArray[i], 0, 0)
        
    }
    requestAnimationFrame(animate)
}

animate();
