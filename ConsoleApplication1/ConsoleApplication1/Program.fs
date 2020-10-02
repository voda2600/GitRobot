// Learn more about F# at https://fsharp.org
// See the 'F# Tutorial' project for more help.
open Microsoft.FSharp.Math
open System
open System.Windows.Forms
open System.Drawing

let height = 400.0
let width = 400.0
let cMax = complex 1.0 1.0
let cMin = complex -1.0 -1.0
let rec isInMandelbrotSet (zero, c, cur_iter, iter) =
    if cur_iter < iter && Complex.Abs(zero)<=2.0 then
        isInMandelbrotSet ( ((zero * zero) + c), c, cur_iter+1, iter )
    else cur_iter

let convertMeasure(x:int, y:int, scale:float, mx:float,my:float) =
       let toX p =
           (p-(width/2.5))/(width/4.0*scale)
       let toY p =
           -(p-(height/2.5))/(height/4.0*scale)
       complex (toX(float x) + mx) (toY(float y) + my)

let colorize c =
    let r = (4 * c) % 255
    let g = (6 * c) % 255
    let b = (8 * c) % 255
    Color.FromArgb(r,g,b)


let createImage (mx, my, iter,scale) =
    let image = new Bitmap(400, 400)
    for x = 0 to image.Width - 1 do
        for y = 0 to image.Height - 1 do
            let count = isInMandelbrotSet( Complex.Zero, convertMeasure(x,y,scale,mx,my), 0, iter)
            if count = iter then
                image.SetPixel(x,y, Color.Black)
            else
                image.SetPixel(x,y, colorize( count ) )
    image
let mutateImage (ans:Form) (i:float)= ans.Paint.Add(fun e -> e.Graphics.DrawImage(createImage(-0.7,0.28,50+Convert.ToInt32(i*0.9),i*3.0), 0, 0))
let ans  = new Form()
//ans.Paint.Add(fun e -> e.Graphics.DrawImage(createImage(-0.7,0.28,100,1.0), 0, 0))
ans.Size <- new Size(400,440)

for i in 1.0..40.0 do
    mutateImage ans i


do Application.Run(ans)




