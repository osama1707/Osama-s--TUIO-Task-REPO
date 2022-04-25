/*
	TUIO C# Demo - part of the reacTIVision project
	http://reactivision.sourceforge.net/

	Copyright (c) 2005-2009 Martin Kaltenbrunner <martin@tuio.org>

	This program is free software; you can redistribute it and/or modify
	it under the terms of the GNU General Public License as published by
	the Free Software Foundation; either version 2 of the License, or
	(at your option) any later version.

	This program is distributed in the hope that it will be useful,
	but WITHOUT ANY WARRANTY; without even the implied warranty of
	MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
	GNU General Public License for more details.

	You should have received a copy of the GNU General Public License
	along with this program; if not, write to the Free Software
	Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA 02111-1307 USA
*/

using System;
using System.Drawing;
using TUIO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class TuioDemoObject : TuioObject
{

		SolidBrush black = new SolidBrush(Color.Black);
		SolidBrush white = new SolidBrush(Color.White);
		public Bitmap img = new Bitmap("1.PNG");
		public Bitmap img2 = new Bitmap("El5.png");
		//public Timer tt = new Timer();
		//int ctTick = 0;
		//List<Ice> ListIce = new List<Ice>();
		//public Bitmap off;




	public TuioDemoObject (long s_id, int f_id, float xpos, float ypos, float angle) : base(s_id,f_id,xpos,ypos,angle) {

	}

		public TuioDemoObject (TuioObject o) : base(o) {
		}

		public void paint(Graphics g) {

			//g.Clear(Color.White);
			int Xpos = (int)(xpos*TuioDemo.width);
			int Ypos = (int)(ypos*TuioDemo.height);
			int size = TuioDemo.height/10;

			g.TranslateTransform(Xpos,Ypos);
			g.RotateTransform((float)(angle/Math.PI*180.0f));
			g.TranslateTransform(-1*Xpos,-1*Ypos);

		//g.FillRectangle(black, new Rectangle(Xpos-size/2,Ypos-size/2,size,size));
		//g.DrawImage(img, Xpos - size / 2, Ypos - size / 2,img.Width,img.Height);

			g.DrawImage(img2, Xpos - size / 2, Ypos - size / 2, 80, 100);
			img2.MakeTransparent(img2.GetPixel(0, 0));



		g.TranslateTransform(Xpos,Ypos);
			g.RotateTransform(-1 * (float)(angle / Math.PI * 180.0f));
			g.TranslateTransform(-1*Xpos,-1*Ypos);

			//Font font = new Font("Arial", 10.0f);
			//g.DrawString(symbol_id + "", font, white, new PointF(Xpos - 10, Ypos - 10));

	}

 //   private void Tt_Tick(object sender, EventArgs e)
 //   {
	//	if (ctTick % 2 == 0)
	//	{
	//		IceDown();

	//	}
	//	ctTick++;
	//	MoveIceDOwn();
	//}
	//public void IceDown()
	//{
	//	Ice pnn = new Ice();
	//	Random rr = new Random();
	//	pnn.img.MakeTransparent(pnn.img.GetPixel(0, 0));
	//	pnn.img = new Bitmap("Ek.png");
	//	pnn.y = -1;
	//	pnn.x = rr.Next(0, 1000);
	//	ListIce.Add(pnn);
	//	tt.Tick += Tt_Tick;
	//	tt.Start();


	//}
	//public void MoveIceDOwn()
	//{
	//	for (int i = 0; i < ListIce.Count; i++)
	//	{
	//		ListIce[i].y++;
	//	}
	//}


}

