using SkiaSharp;

const float size = 1000;

LinearGradient();
RadialGradient();

void LinearGradient()
{
    using var fileStream = new FileStream("linear_gradient.svg", FileMode.Create);
    using var canvas = SKSvgCanvas.Create(new SKRect(0f, 0f, size, size), fileStream);
    using var paint = new SKPaint
    {
        Shader = SKShader.CreateLinearGradient(
            new SKPoint(0, 0),
            new SKPoint(size, size),
            [SKColors.CornflowerBlue, SKColors.YellowGreen],
            null,
            SKShaderTileMode.Clamp
        )
    };
    canvas.DrawPaint(paint);
    canvas.Flush();
}

void RadialGradient()
{
    using var fileStream = new FileStream("radial_gradient.svg", FileMode.Create);
    using var canvas = SKSvgCanvas.Create(new SKRect(0f, 0f, size, size), fileStream);
    using var paint = new SKPaint
    {
        Shader = SKShader.CreateRadialGradient(
            new SKPoint(size / 2, size / 2),
            size / 2,
            [SKColors.CornflowerBlue, SKColors.YellowGreen],
            null,
            SKShaderTileMode.Clamp
        )
    };
    canvas.DrawPaint(paint);
    canvas.Flush();
}
