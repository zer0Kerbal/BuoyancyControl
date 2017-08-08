/*
MIT License

Copyright (c) 2017 William "Xyphos" Scott

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
*/

namespace BuoyancyControl
{
    public class BuoyancyControl : PartModule
    {
        [KSPField(isPersistant = true, advancedTweakable = true, guiName = "Buoyancy", guiActive = true, guiActiveEditor = true)]
        [UI_FloatRange(scene = UI_Scene.Editor, affectSymCounterparts = UI_Scene.All, minValue = 0.0f, maxValue = 2.0f, stepIncrement = 0.05f, controlEnabled = false)]
        public float Buoyancy;

        public override void OnStart(StartState state)
        {
            base.OnStart(state);

            if (state == StartState.Editor)
            {
                Fields["Buoyancy"].SetValue(part.buoyancy, this);
                return;
            }

            part.buoyancy = Buoyancy;
        }
    }
}
