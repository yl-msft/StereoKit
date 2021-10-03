﻿using StereoKit;

class TestLayout : ITest
{
	public void Initialize() { Tests.RunForFrames(2); }
	public void Shutdown() { }
	public void Update()
	{
		Tests.Screenshot(1, 400, 600, "Tests/Layout.jpg", V.XYZ(0, -0.1f, 0.25f), V.XYZ(0, -0.1f, 0));

		Pose pose = new Pose(Vec3.Zero, Quat.LookDir(0,0,1));
		UI.WindowBegin("Layout", ref pose);

		Bounds layout = UI.LayoutReserve(Vec2.Zero);
		layout.dimensions.z = U.cm;
		Mesh.Cube.Draw(Material.Default, Matrix.TS(layout.center, layout.dimensions));
		Lines.Add(UI.LayoutAt, UI.LayoutAt + V.XYZ( 0,0,-U.cm * 3 ), Color32.Black, 0.004f);

		layout = UI.LayoutReserve(Vec2.Zero, false);
		layout.dimensions.z = U.cm;
		Mesh.Cube.Draw(Material.Default, Matrix.TS(layout.center, layout.dimensions));


		layout = UI.LayoutReserve(V.XY(4 * U.cm, 0), false);
		layout.dimensions.z = U.cm;
		Mesh.Cube.Draw(Material.Default, Matrix.TS(layout.center, layout.dimensions));

		UI.SameLine();
		UI.LayoutReserve(V.XY(4 * U.cm, 0), false);
		layout = UI.LayoutLast;
		layout.dimensions.z = U.cm;
		Mesh.Cube.Draw(Material.Default, Matrix.TS(layout.center, layout.dimensions));


		UI.LayoutReserve(V.XY(4 * U.cm, 0), true);
		layout = UI.LayoutLast;
		layout.dimensions.z = U.cm;
		Mesh.Cube.Draw(Material.Default, Matrix.TS(layout.center, layout.dimensions));

		UI.SameLine();
		layout = UI.LayoutReserve(V.XY(4 * U.cm, 0), true);
		layout.dimensions.z = U.cm;
		Mesh.Cube.Draw(Material.Default, Matrix.TS(layout.center, layout.dimensions));


		UI.Button("hi", V.XY( 4 * U.cm, UI.LineHeight ));
		UI.SameLine();
		UI.Button("hi2", V.XY( 4 * U.cm, UI.LineHeight ));

		UI.Button("hi3");
		UI.SameLine();
		Lines.Add(UI.LayoutAt, UI.LayoutAt + V.XYZ(0, 0, -U.cm * 3), Color32.Black, 0.004f);
		UI.Button("hi4");

		UI.WindowEnd();
	}
}
