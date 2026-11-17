using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FlyWeightRain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
        }

        Graphics g;
        List<Drop> drops = new List<Drop>();
        List<FlyDrop> fdrops = new List<FlyDrop>();
        Random r = new Random();
        Param param = new Param();
        Param param1 = new Param1();
        Param param2 = new Param2();

        // Звичайна крапля (кожна зберігає свою картинку)
        private void BtnDrop_Click(object sender, EventArgs e)
        {
            drops.Add(new Drop(r.Next(150, 500), r.Next(10, 450)));
            drops[drops.Count - 1].Show(g);
            Text = drops.Count.ToString();
        }

        // Легка крапля (картинка спільна: param1 або param2)
        private void BtnFlyDrop_Click(object sender, EventArgs e)
        {
            if (r.Next() % 2 == 0)
            {
                fdrops.Add(new FlyDrop(r.Next(150, 500), r.Next(10, 450), 6, param1));
            }
            else
            {
                fdrops.Add(new FlyDrop(r.Next(150, 500), r.Next(10, 450), 12, param2));
            }
            fdrops[fdrops.Count - 1].Show(g);
            Text = fdrops.Count.ToString();
        }

        // Імітація дощу: таймер рухає всі легкі краплі
        private void BtnRain_Click(object sender, EventArgs e)
        {
            TmrRain.Enabled = !TmrRain.Enabled;
            BtnRain.Text = TmrRain.Enabled ? "Зупинити дощ" : "Імітація дощу";
        }

        private void TmrRain_Tick(object sender, EventArgs e)
        {
            if (fdrops.Count < 300)
            {
                int x = r.Next(150, Math.Max(200, ClientSize.Width - 30));
                if (r.Next() % 2 == 0)
                    fdrops.Add(new FlyDrop(x, 0, 6, param1));
                else
                    fdrops.Add(new FlyDrop(x, 0, 12, param2));
            }

            // очищаємо лише область малювання, щоб не зачепити кнопки
            g.FillRectangle(new SolidBrush(BackColor), 130, 0, ClientSize.Width - 130, ClientSize.Height);
            foreach (FlyDrop d in fdrops)
            {
                d.Move(ClientSize.Height);
                d.Show(g);
            }
            Text = fdrops.Count.ToString();
        }
    }
}
