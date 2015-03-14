using DxLibDLL;
using System;

namespace Test
{
    class TestApplication
    {
        ///<summary>
        ///アプリケーションのエントリーポイント（ここからプログラムが始まる）
        ///</summary>
        [STAThread]
        static void Main()
        {
            DX.ChangeWindowMode(DX.TRUE);

            DX.SetGraphMode(800, 600, 32);

            if (DX.DxLib_Init() == -1)
            {
                return;
            }

            DX.DrawBox(100, 100, 200, 150, DX.GetColor(255, 0, 255),DX.TRUE);
            DX.DrawString(100,200,"This is Sample",DX.GetColor(255,255,64));

            DX.WaitKey();

            DX.DxLib_End();

            return;
        }
    }
}