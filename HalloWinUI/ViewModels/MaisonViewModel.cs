using HalloWinUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalloWinUI.ViewModels
{
    internal class MaisonViewModel : BaseViewModel
    {
        private readonly Maison _maison;

        public string? NumeroCivique
        {
            get { return _maison.NumeroCivique; }
            set
            {
                if (_maison.NumeroCivique != value)
                {
                    _maison.NumeroCivique = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string? Rue
        {
            get { return _maison.Rue; }
            set
            {
                if (_maison.Rue != value)
                {
                    _maison.Rue = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string? Ville
        {
            get { return _maison.Ville; }
            set
            {
                if (_maison.Ville != value)
                {
                    _maison.Ville = value;
                    RaisePropertyChanged();
                }
            }
        }

        public string? CodePostal
        {
            get { return _maison.CodePostal; }
            set
            {
                if (_maison.CodePostal != value)
                {
                    _maison.CodePostal = value;
                    RaisePropertyChanged();
                }
            }
        }
    }
}
