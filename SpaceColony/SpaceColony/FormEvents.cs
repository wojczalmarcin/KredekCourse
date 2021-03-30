using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceColony
{
    public partial class FormEvents : Form
    {
        // obiekt przechowujący planetę
        private Planet planet;
        // obiekt wydarzeń katastroficznych
        private CataclysmEvents cataclysmEvents;
        /// <summary>
        /// Konstruktor
        /// </summary>
        /// <param name="planet"></param>
        public FormEvents(Planet planet)
        {
            this.planet = planet;
            InitializeComponent();
        }
        /// <summary>
        /// Załadowanie okienka wydarzenia
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEvents_Load(object sender, EventArgs e)
        {
            
            cataclysmEvents = new CataclysmEvents(planet);
            Random random = new Random();
            int eventChance = random.Next(17);
            if (eventChance < 4)
            {
                this.BackgroundImage = Properties.Resources.meteor;
                cataclysmEvents.Meteorite();
            }
            else if (eventChance < 8)
            {
                this.BackgroundImage = Properties.Resources.volcano;
                cataclysmEvents.VolcanoEuption();
            }
            else
            {
                this.BackgroundImage = Properties.Resources.wind;
                cataclysmEvents.SolarWind();
            }
            labelEventStatus.Text = cataclysmEvents.eventStatus;
        }
    }
}
