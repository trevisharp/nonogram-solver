using System;
using System.Collections.Generic;
using System.Drawing;

using Pamella;

var view = new MainView();
App.Open(view);

public class MainView : View
{
    Nonogram nono;
    RectangleF nonoRect;

    protected override void OnStart(IGraphics g)
    {
        g.SubscribeKeyDownEvent(key =>
        {
            if (key == System.Windows.Forms.Keys.Escape)
                App.Close();
            
            if (key == System.Windows.Forms.Keys.Space)
                nono.Solve();
        });

        this.nono = new Nonogram(25);

        float side = .8f * g.Height;
        this.nonoRect = new RectangleF(
            (g.Width - side) / 2,
            (g.Height - side) / 2,
            side, side
        );

        nono.HorizontalAdd(7, 3, 1, 1, 7);
        nono.HorizontalAdd(1, 1, 2, 2, 1, 1);
        nono.HorizontalAdd(1, 3, 1, 3, 1, 1, 3, 1);
        nono.HorizontalAdd(1, 3, 1, 1, 6, 1, 3, 1);
        nono.HorizontalAdd(1, 3, 1, 5, 2, 1, 3, 1);
        nono.HorizontalAdd(1, 1, 2, 1, 1);
        nono.HorizontalAdd(7, 1, 1, 1, 1, 1, 7);
        nono.HorizontalAdd(3, 3);
        nono.HorizontalAdd(1, 2, 3, 1, 1, 3, 1, 1, 2);
        nono.HorizontalAdd(1, 1, 3, 2, 1, 1);
        nono.HorizontalAdd(4, 1, 4, 2, 1, 2);
        nono.HorizontalAdd(1, 1, 1, 1, 1, 4, 1, 3);
        nono.HorizontalAdd(2, 1, 1, 1, 2, 5);
        nono.HorizontalAdd(3, 2, 2, 6, 3, 1);
        nono.HorizontalAdd(1, 9, 1, 1, 2, 1);
        nono.HorizontalAdd(2, 1, 2, 2, 3, 1);
        nono.HorizontalAdd(3, 1, 1, 1, 1, 5, 1);
        nono.HorizontalAdd(1, 2, 2, 5);
        nono.HorizontalAdd(7, 1, 2, 1, 1, 1, 3);
        nono.HorizontalAdd(1, 1, 2, 1, 2, 2, 1);
        nono.HorizontalAdd(1, 3, 1, 4, 5, 1);
        nono.HorizontalAdd(1, 3, 1, 3, 10, 2);
        nono.HorizontalAdd(1, 3, 1, 1, 6, 6);
        nono.HorizontalAdd(1, 1, 2, 1, 1, 2);
        nono.HorizontalAdd(7, 2, 1, 2, 5);

        nono.VerticalAdd(7, 2, 1, 1, 7);
        nono.VerticalAdd(1, 1, 2, 2, 1, 1);
        nono.VerticalAdd(1, 3, 1, 3, 1, 3, 1, 3, 1);
        nono.VerticalAdd(1, 3, 1, 1, 5, 1, 3, 1);
        nono.VerticalAdd(1, 3, 1, 1, 4, 1, 3, 1);
        nono.VerticalAdd(1, 1, 1, 2, 1, 1);
        nono.VerticalAdd(7, 1, 1, 1, 1, 1, 7);
        nono.VerticalAdd(1, 1, 3);
        nono.VerticalAdd(2, 1, 2, 1, 8, 2, 1);
        nono.VerticalAdd(2, 2, 1, 2, 1, 1, 1, 2);
        nono.VerticalAdd(1, 7, 3, 2, 1);
        nono.VerticalAdd(1, 2, 3, 1, 1, 1, 1, 1);
        nono.VerticalAdd(4, 1, 1, 2, 6);
        nono.VerticalAdd(3, 3, 1, 1, 1, 3, 1);
        nono.VerticalAdd(1, 2, 5, 2, 2);
        nono.VerticalAdd(2, 2, 1, 1, 1, 1, 1, 2, 1);
        nono.VerticalAdd(1, 3, 3, 2, 1, 8, 1);
        nono.VerticalAdd(6, 2, 1);
        nono.VerticalAdd(7, 1, 4, 1, 1, 3);
        nono.VerticalAdd(1, 1, 1, 1, 4);
        nono.VerticalAdd(1, 3, 1, 3, 7, 1);
        nono.VerticalAdd(1, 3, 1, 1, 1, 2, 1, 1, 4);
        nono.VerticalAdd(1, 3, 1, 4, 3, 3);
        nono.VerticalAdd(1, 1, 2, 2, 2, 6, 1);
        nono.VerticalAdd(7, 1, 3, 2, 1, 1);

        nono.AddUnknowBlack(3, 3);
        nono.AddUnknowBlack(4, 3);
        nono.AddUnknowBlack(12, 3);
        nono.AddUnknowBlack(13, 3);
        nono.AddUnknowBlack(21, 3);

        nono.AddUnknowBlack(6, 8);
        nono.AddUnknowBlack(7, 8);
        nono.AddUnknowBlack(10, 8);
        nono.AddUnknowBlack(14, 8);
        nono.AddUnknowBlack(15, 8);
        nono.AddUnknowBlack(18, 8);

        nono.AddUnknowBlack(6, 16);
        nono.AddUnknowBlack(11, 16);
        nono.AddUnknowBlack(16, 16);
        nono.AddUnknowBlack(20, 16);

        nono.AddUnknowBlack(3, 21);
        nono.AddUnknowBlack(4, 21);
        nono.AddUnknowBlack(9, 21);
        nono.AddUnknowBlack(10, 21);
        nono.AddUnknowBlack(15, 21);
        nono.AddUnknowBlack(20, 21);
        nono.AddUnknowBlack(21, 21);
    }

    protected override void OnRender(IGraphics g)
    {
        g.Clear(Color.White);
        
        nono.Draw(nonoRect, g);

        Invalidate();
    }
}

public class Nonogram
{
    private const byte white = 255;
    private const byte unknowBlack = 254;
    private const byte baseLine = 128;
    private const byte unknow = 0;

    private int size;
    private byte[] data;
    private List<byte[]> horRules;
    private List<byte[]> verRules;

    public byte this[int i, int j]
    {
        get => data[i + j * size];
        set => data[i + j * size] = value;
    }

    public Nonogram(int size)
    {
        this.size = size;
        this.data = new byte[size * size];
        this.horRules = new List<byte[]>();
        this.verRules = new List<byte[]>();
    }

    public void HorizontalAdd(params byte[] arr)
        => this.horRules.Add(arr);
    
    public void VerticalAdd(params byte[] arr)
        => this.verRules.Add(arr);
    
    public void AddUnknowBlack(int i, int j)
        => this[i, j] = unknowBlack;

    public void Draw(RectangleF rect, IGraphics g)
    {
        RectangleF mainRect = new RectangleF(
            rect.X - .2f * rect.Width,
            rect.Y - .2f * rect.Height,
            rect.Width,
            rect.Height
        );

        float square = rect.Width / size;

        for (int j = 0; j < size; j++)
        {
            for (int i = 0; i < size; i++)
            {
                var value = this.data[i + size * j];

                g.FillRectangle(
                    rect.X + i * square,
                    rect.Y + j * square,
                    square, square,
                    value switch
                    {
                        0 => Brushes.Gray,
                        255 => Brushes.White,
                        _ => Brushes.Black
                    }
                );
                
                g.DrawRectangle(
                    rect.X + i * square,
                    rect.Y + j * square,
                    square, square,
                    Pens.Black
                );
            }
        }
    }

    public void Solve()
    {
        for (int line = 0; line < size; line++)
            minMaxSolutionLineInterseption(line);
        
        for (int column = 0; column < size; column++)
            minMaxSolutionColumnInterseption(column);
    }

    private void minMaxSolutionColumnInterseption(int column)
    {
        var data = getFilteredDataCopy(column, false);
        var rule = horRules[column];
        minMaxSolutionInterseption(data, rule);
        setFilteredDataCopy(column, false, data);
    }

    private void minMaxSolutionLineInterseption(int line)
    {
        var data = getFilteredDataCopy(line, true);
        var rule = horRules[line];
        minMaxSolutionInterseption(data, rule);
        setFilteredDataCopy(line, true, data);
    }

    private void minMaxSolutionInterseption(byte[] data, byte[] rule)
    {
        var minData = copy(data);
        minSolution(minData, rule);

        var maxData = copy(data);
        revert(maxData);
        swapColors(maxData, rule.Length);
        minSolution(maxData, rule);
        swapColors(maxData, rule.Length);
        revert(maxData);

        for (int i = 0; i < size; i++)
        {
            if (minData[i] == maxData[i])
                data[i] = minData[i];
        }

        decideUnknowBlack(data);
        discoverBySize(data, rule);
    }

    private void swapColors(byte[] arr, int colorCount)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == unknow || arr[i] >= unknowBlack)
                continue;
            
            arr[i] = (byte)(colorCount + 1 - arr[i]);
        }
    }
    
    private void revert(byte[] arr)
    {
        int end = arr.Length - 1;
        for (int i = 0; i < arr.Length / 2; i++)
        {
            byte temp = arr[i];
            arr[i] = arr[end - i];
            arr[end - i] = temp;
        }
    }

    private byte[] copy(byte[] arr)
    {
        byte[] copy = new byte[size];
        Array.Copy(arr, copy, arr.Length);
        return copy;
    }

    private void setFilteredDataCopy(int baseIndex, bool isLineFilter, byte[] data)
    {
        for (int k = 0; k < size; k++)
        {
            int index = isLineFilter ?
                k + baseIndex * size :
                baseIndex + k * size;

            var value = this.data[index];
            var newValue = data[k];

            if (value == newValue)
                continue;

            if (newValue == unknow)
                continue;
            
            if (newValue >= unknowBlack)
            {
                this.data[index] = newValue;
                continue;
            }

            if (value == unknowBlack)
                value = unknow;

            this.data[index] = isLineFilter ?
                (byte)((value & 0b1111_0000) + newValue) :
                (byte)((value & 0b0000_1111) + (newValue << 4));
        }
    }

    private byte[] getFilteredDataCopy(int baseIndex, bool isLineFilter)
    {
        byte[] copy = new byte[size];

        for (int k = 0; k < size; k++)
        {
            int index = isLineFilter ?
                k + baseIndex * size :
                baseIndex + k * size;

            var value = data[index];

            if (value > unknow && value < unknowBlack)
            {
                value = isLineFilter ?
                    (byte)(value % 16) :
                    (byte)(value >> 4);
                
                if (value == 0)
                    value = unknowBlack;
            }

            copy[k] = value;
        }

        return copy;
    }
    
    private void decideUnknowBlack(byte[] data)
    {
        for (int i = 1; i < size - 1; i++)
        {
            if (data[i] != unknowBlack)
                continue;
            
            var value = data[i - 1];
            if (value != unknowBlack && value != white && value != unknow)
                data[i] = value;
            
            value = data[i + 1];
            if (value != unknowBlack && value != white && value != unknow)
                data[i] = value;
        }
        
        for (int i = size - 2; i > 0; i--)
        {
            if (data[i] != unknowBlack)
                continue;
            
            var value = data[i - 1];
            if (value != unknowBlack && value != white && value != unknow)
                data[i] = value;
            
            value = data[i + 1];
            if (value != unknowBlack && value != white && value != unknow)
                data[i] = value;
        }
    }
    
    private void discoverBySize(byte[] data, byte[] rule)
    {
        int sequenceSize = 0;
        bool inSequence = false;
        for (int i = 0; i < size; i++)
        {
            if (data[i] > unknow && data[i] < white)
            {
                sequenceSize++;
                inSequence = true;
                continue;
            }
            
            if (!inSequence)
                continue;
            
            inSequence = false;
            int seqSize = sequenceSize;
            sequenceSize = 0;
            
            if (data[i - 1] == unknowBlack)
                continue;
            
            if (seqSize < rule[data[i - 1] - 1])
                continue;
            
            if (i < size)
                data[i] = white;
            
            if (i - 1 - seqSize >= 0)
                data[i - 1 - seqSize] = white;
        }
    }

    private void minSolution(byte[] solutionBuffer, byte[] rule)
    {
        int i = 0;
        byte[] solution = solutionBuffer;
        var colorBins = countColor(solutionBuffer, rule.Length);

        for (int j = 0; j < rule.Length; j++)
        {
            var color = (byte)(j + 1);
            var ruleSize = rule[j];

            if (colorBins[j] > 0)
            {
                fillColor(solution, color);
                int max = findMaxColor(solution, color);
                i = max - ruleSize + 1;
            }

            bool hasSpace = testSpace(solution, i, rule[j], color);
            if (!hasSpace)
                continue;
            
            for (int k = 0; k < rule[j]; k++, i++)
                solution[i] = color;
            
            i++;
        }
    }

    private void fillColor(byte[] arr, byte color)
    {
        int min = findMinColor(arr, color);
        var max = findMaxColor(arr, color);

        if (min == max)
            return;

        for (int i = min + 1; i < max; i++)
            arr[i] = color;
    }

    private int[] countColor(byte[] arr, int colorCount)
    {
        int[] count = new int[colorCount];
        
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > unknow && arr[i] < unknowBlack)
                count[arr[i] - 1]++;
        }

        return count;
    }

    private int findMinColor(byte[] arr, byte color)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == color)
                return i;
        }
        return -1;
    }

    private int findMaxColor(byte[] arr, byte color)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            if (arr[i] == color)
                return i;
        }
        return -1;
    }

    private bool testSpace(byte[] arr, int start, int needSpace, byte crrColor)
    {
        if (start < 0)
            return false;
        
        int end = start + needSpace;
        if (end > arr.Length)
            return false;

        for (int i = start; i < end; i++)
        {
            if (arr[i] == unknow)
                continue;
            
            if (arr[i] == crrColor)
                continue;
            
            if (arr[i] == unknowBlack)
                continue;
            
            return false;
        }

        if (end == arr.Length)
            return true;
        
        int next = arr[end];
        if (next < white && next > unknow)
            return false;
            
        return true;
    }
}