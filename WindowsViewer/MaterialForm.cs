using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using oec;
namespace WindowsViewer
{
    public partial class MaterialForm : Form
    {
        public MaterialForm(Form1 form, Materials mate, ParticleInfoManaged info)
        {
            this.MainForm = form;
            this.InitializeComponent();
            this.SetButtons(mate, info);
        }
        public void SetButtons(Materials mate, ParticleInfoManaged info)
        {
            if (mate != Materials.Fire)
            {
                switch (mate)
                {
                    case Materials.Brittle:
                        this.radioBrittle.Checked = true;
                        break;
                    case Materials.Cold:
                        this.radioCold.Checked = true;
                        break;
                    case Materials.Elastic:
                        this.radioErastic.Checked = true;
                        break;
                    case Materials.Fuel:
                        this.radioFuel.Checked = true;
                        break;
                    case Materials.Gas:
                        this.radioGas.Checked = true;
                        break;
                    case Materials.Hot:
                        this.radioHot.Checked = true;
                        break;
                    case Materials.Inflow:
                        this.radioFlow.Checked = true;
                        break;
                    case Materials.Kome:
                        this.radioRice.Checked = true;
                        break;
                    case Materials.Light:
                        this.radioOil.Checked = true;
                        break;
                    case Materials.Mochi:
                        this.radioMochi.Checked = true;
                        break;
                    case Materials.Outflow:
                        this.radioOut.Checked = true;
                        break;
                    case Materials.Powder:
                        this.radioPowder.Checked = true;
                        break;
                    case Materials.Aqua:
                        this.radioAqua.Checked = true;
                        break;
                    case Materials.Rigid:
                        this.radioRigid.Checked = true;
                        break;
                    case Materials.String:
                        this.radioString.Checked = true;
                        break;
                    case Materials.Tensile:
                        this.radioTensil.Checked = true;
                        break;
                    case Materials.Users:
                        this.radioUsers.Checked = true;
                        break;
                    case Materials.Viscous:
                        this.radioVisco.Checked = true;
                        break;
                    case Materials.Wall:
                        this.radioWall.Checked = true;
                        break;
                    case Materials.Axis:
                        this.radioAxis.Checked = true;
                        break;
                }
            }
            else
            {
                this.radioFire.Checked = true;
            }
            if ((info & ParticleInfoManaged.Aqua) != ParticleInfoManaged.None)
            {
                this.checkWater.Checked = true;
            }
            else
            {
                this.checkWater.Checked = false;
            }
            if ((info & ParticleInfoManaged.Mochi) != ParticleInfoManaged.None)
            {
                this.checkMochi.Checked = true;
            }
            else
            {
                this.checkMochi.Checked = false;
            }
            if ((info & ParticleInfoManaged.Spring) != ParticleInfoManaged.None)
            {
                this.checkString.Checked = true;
            }
            else
            {
                this.checkString.Checked = false;
            }
            if ((info & ParticleInfoManaged.Elastic) != ParticleInfoManaged.None)
            {
                this.checkElastic.Checked = true;
            }
            else
            {
                this.checkElastic.Checked = false;
            }
            if ((info & ParticleInfoManaged.Rigid) != ParticleInfoManaged.None)
            {
                this.checkSolid.Checked = true;
            }
            else
            {
                this.checkSolid.Checked = false;
            }
            if ((info & ParticleInfoManaged.Wall) != ParticleInfoManaged.None)
            {
                this.checkWall.Checked = true;
            }
            else
            {
                this.checkWall.Checked = false;
            }
            if ((info & ParticleInfoManaged.Zombie) != ParticleInfoManaged.None)
            {
                this.checkZombie.Checked = true;
                this.radioZombie.Checked = true;
            }
            else
            {
                this.checkZombie.Checked = false;
                this.radioZombie.Checked = false;
            }
            if ((info & ParticleInfoManaged.Brittle) != ParticleInfoManaged.None)
            {
                this.checkBrittle.Checked = true;
            }
            else
            {
                this.checkBrittle.Checked = false;
            }
            if ((info & ParticleInfoManaged.Users) != ParticleInfoManaged.None)
            {
                this.checkUsers.Checked = true;
            }
            else
            {
                this.checkUsers.Checked = false;
            }
            if ((info & ParticleInfoManaged.Dense) != ParticleInfoManaged.None)
            {
                this.checkHeavy.Checked = true;
            }
            else
            {
                this.checkHeavy.Checked = false;
            }
            if ((info & ParticleInfoManaged.Light) != ParticleInfoManaged.None)
            {
                this.checkLight.Checked = true;
            }
            else
            {
                this.checkLight.Checked = false;
            }
            if ((info & ParticleInfoManaged.Linked) != ParticleInfoManaged.None)
            {
                this.checkLink.Checked = true;
            }
            else
            {
                this.checkLink.Checked = false;
            }
            if ((info & ParticleInfoManaged.Axis) != ParticleInfoManaged.None)
            {
                this.checkAxis.Checked = true;
            }
            else
            {
                this.checkAxis.Checked = false;
            }
            if ((info & ParticleInfoManaged.Outflow) != ParticleInfoManaged.None)
            {
                this.checkOut.Checked = true;
            }
            else
            {
                this.checkOut.Checked = false;
            }
            if ((info & ParticleInfoManaged.Inflow) != ParticleInfoManaged.None)
            {
                this.checkFlow.Checked = true;
            }
            else
            {
                this.checkFlow.Checked = false;
            }
            if ((info & ParticleInfoManaged.Cold) != ParticleInfoManaged.None)
            {
                this.checkCold.Checked = true;
            }
            else
            {
                this.checkCold.Checked = false;
            }
            if ((info & ParticleInfoManaged.Hot) != ParticleInfoManaged.None)
            {
                this.checkHot.Checked = true;
            }
            else
            {
                this.checkHot.Checked = false;
            }
            if ((info & ParticleInfoManaged.Gas) != ParticleInfoManaged.None)
            {
                this.checkGas.Checked = true;
            }
            else
            {
                this.checkGas.Checked = false;
            }
            if ((info & ParticleInfoManaged.Kome) != ParticleInfoManaged.None)
            {
                this.checkRice.Checked = true;
            }
            else
            {
                this.checkRice.Checked = false;
            }
            if ((info & ParticleInfoManaged.Viscous) != ParticleInfoManaged.None)
            {
                this.checkVisco.Checked = true;
            }
            else
            {
                this.checkVisco.Checked = false;
            }
            if ((info & ParticleInfoManaged.Tensile) != ParticleInfoManaged.None)
            {
                this.checkTensil.Checked = true;
            }
            else
            {
                this.checkTensil.Checked = false;
            }
            if ((info & ParticleInfoManaged.Fuel) != ParticleInfoManaged.None)
            {
                this.checkFuel.Checked = true;
            }
            else
            {
                this.checkFuel.Checked = false;
            }
            if ((info & ParticleInfoManaged.Powder) != ParticleInfoManaged.None)
            {
                this.checkPowder.Checked = true;
                return;
            }
            this.checkPowder.Checked = false;
        }
        private void SetMaterial()
        {
            this.MainForm.GetOECPanel();
            if (this.radioAqua.Checked)
            {
                this.MainForm.SetMaterial(Materials.Aqua, "Water");
            }
            if (this.radioWall.Checked)
            {
                this.MainForm.SetMaterial(Materials.Wall, "Wall");
            }
            if (this.radioRigid.Checked)
            {
                this.MainForm.SetMaterial(Materials.Rigid, "Solid");
            }
            if (this.radioErastic.Checked)
            {
                this.MainForm.SetMaterial(Materials.Elastic, "Elastic");
            }
            if (this.radioString.Checked)
            {
                this.MainForm.SetMaterial(Materials.String, "String");
            }
            if (this.radioMochi.Checked)
            {
                this.MainForm.SetMaterial(Materials.Mochi, "Rice Cake");
            }
            if (this.radioFire.Checked)
            {
                this.MainForm.SetMaterial(Materials.Fire, "Fire");
            }
            if (this.radioPowder.Checked)
            {
                this.MainForm.SetMaterial(Materials.Powder, "Powder");
            }
            if (this.radioFuel.Checked)
            {
                this.MainForm.SetMaterial(Materials.Fuel, "Wood");
            }
            if (this.radioTensil.Checked)
            {
                this.MainForm.SetMaterial(Materials.Tensile, "Surface Tension");
            }
            if (this.radioVisco.Checked)
            {
                this.MainForm.SetMaterial(Materials.Viscous, "Viscous");
            }
            if (this.radioRice.Checked)
            {
                this.MainForm.SetMaterial(Materials.Kome, "Rice");
            }
            if (this.radioGas.Checked)
            {
                this.MainForm.SetMaterial(Materials.Gas, "Steam");
            }
            if (this.radioHot.Checked)
            {
                this.MainForm.SetMaterial(Materials.Hot, "Hot Wall");
            }
            if (this.radioCold.Checked)
            {
                this.MainForm.SetMaterial(Materials.Cold, "Cold Wall");
            }
            if (this.radioFlow.Checked)
            {
                this.MainForm.SetMaterial(Materials.Inflow, "Faucet");
            }
            if (this.radioOut.Checked)
            {
                this.MainForm.SetMaterial(Materials.Outflow, "Outflow");
            }
            if (this.radioAxis.Checked)
            {
                this.MainForm.SetMaterial(Materials.Axis, "Fulcrum");
            }
            if (this.radioOil.Checked)
            {
                this.MainForm.SetMaterial(Materials.Light, "Oil");
            }
            if (this.radioUsers.Checked)
            {
                this.MainForm.SetMaterial(Materials.Users, "Character");
            }
            if (this.radioBrittle.Checked)
            {
                this.MainForm.SetMaterial(Materials.Brittle, "Brittle");
            }
            if (this.radioZombie.Checked)
            {
                this.MainForm.SetMaterial(Materials.NoMaterial, "Zombie");
                this.MainForm.SetParticleInfo(ParticleInfoManaged.Zombie);
            }
        }
        private void SetCustomMaterial()
        {
            ParticleInfoManaged particleInfoManaged = ParticleInfoManaged.None;
            if (this.checkWater.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Aqua;
            }
            if (this.checkMochi.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Mochi;
            }
            if (this.checkString.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Spring;
            }
            if (this.checkElastic.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Elastic;
            }
            if (this.checkSolid.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Rigid;
            }
            if (this.checkWall.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Wall;
            }
            if (this.checkZombie.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Zombie;
            }
            if (this.checkBrittle.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Brittle;
            }
            if (this.checkUsers.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Users;
            }
            if (this.checkHeavy.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Dense;
            }
            if (this.checkLight.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Light;
            }
            if (this.checkLink.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Linked;
            }
            if (this.checkAxis.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Axis;
            }
            if (this.checkOut.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Outflow;
            }
            if (this.checkFlow.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Inflow;
            }
            if (this.checkCold.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Cold;
            }
            if (this.checkHot.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Hot;
            }
            if (this.checkGas.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Gas;
            }
            if (this.checkRice.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Kome;
            }
            if (this.checkVisco.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Viscous;
            }
            if (this.checkTensil.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Tensile;
            }
            if (this.checkFuel.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Fuel;
            }
            if (this.checkPowder.Checked)
            {
                particleInfoManaged |= ParticleInfoManaged.Powder;
            }
            this.MainForm.SetParticleInfo(particleInfoManaged);
        }
        private void Basic_CheckedChanged(object sender, EventArgs e)
        {
            this.SetMaterial();
        }
        private void Custom_CheckedChanged(object sender, EventArgs e)
        {
            this.SetCustomMaterial();
        }
        private Form1 MainForm;
    }
}
