using System;
using System.Collections.Generic;
using SanzPansAntonioProyectoXamarin.Models;
using Xamarin.Forms;

namespace SanzPansAntonioProyectoXamarin
{
    public partial class GhostWikiCardsPage : ContentPage
    {
        public List<GhostEvidence> GhostEvidences { get; set; }

        public GhostWikiCardsPage()
        {
            InitializeComponent();
            ControListView();
        }
        public void ControListView()
        {
            this.GhostEvidences = new List<GhostEvidence>();
            GhostEvidence ghostEvidence = new GhostEvidence()
            {
                Id = 1,
                IdEvidence1 = 2,
                IdEvidence2 = 3,
                IdEvidence3 = 4
            };
            this.GhostEvidences.Add(ghostEvidence);

            ghostEvidence = new GhostEvidence()
            {
                Id = 2,
                IdEvidence1 = 4,
                IdEvidence2 = 6,
                IdEvidence3 = 7
            };
            this.GhostEvidences.Add(ghostEvidence);

            ghostEvidence = new GhostEvidence()
            {
                Id = 3,
                IdEvidence1 = 2,
                IdEvidence2 = 5,
                IdEvidence3 = 7
            };
            this.GhostEvidences.Add(ghostEvidence);

            ghostEvidence = new GhostEvidence()
            {
                Id = 4,
                IdEvidence1 = 4,
                IdEvidence2 = 5,
                IdEvidence3 = 7
            };
            this.GhostEvidences.Add(ghostEvidence);
  
            ghostEvidence = new GhostEvidence()
            {
                Id = 5,
                IdEvidence1 = 2,
                IdEvidence2 = 6,
                IdEvidence3 = 7
            };
            this.GhostEvidences.Add(ghostEvidence);

            ghostEvidence = new GhostEvidence()
            {
                Id = 6,
                IdEvidence1 = 2,
                IdEvidence2 = 4,
                IdEvidence3 = 5
            };
            this.GhostEvidences.Add(ghostEvidence);

            this.GhostEvidences.Add(ghostEvidence);

            ghostEvidence = new GhostEvidence()
            {
                Id = 2,
                IdEvidence1 = 4,
                IdEvidence2 = 6,
                IdEvidence3 = 7
            };
            this.GhostEvidences.Add(ghostEvidence);

            ghostEvidence = new GhostEvidence()
            {
                Id = 3,
                IdEvidence1 = 2,
                IdEvidence2 = 5,
                IdEvidence3 = 7
            };
            this.GhostEvidences.Add(ghostEvidence);

            ghostEvidence = new GhostEvidence()
            {
                Id = 4,
                IdEvidence1 = 4,
                IdEvidence2 = 5,
                IdEvidence3 = 7
            };
            this.GhostEvidences.Add(ghostEvidence);

            ghostEvidence = new GhostEvidence()
            {
                Id = 5,
                IdEvidence1 = 2,
                IdEvidence2 = 6,
                IdEvidence3 = 7
            };
            this.GhostEvidences.Add(ghostEvidence);

            ghostEvidence = new GhostEvidence()
            {
                Id = 6,
                IdEvidence1 = 2,
                IdEvidence2 = 4,
                IdEvidence3 = 5
            };
            this.GhostEvidences.Add(ghostEvidence);
   
            this.ghostEvidences.ItemsSource = this.GhostEvidences;
        }
    }
}
