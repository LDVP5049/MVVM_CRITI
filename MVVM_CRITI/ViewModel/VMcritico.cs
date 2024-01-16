using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVM_CRITI.ViewModel;

namespace MVVM_CRITI.ViewModel
{
    internal class VMcritico : BaseViewModel
    {
        #region VARIABLES
        string _nombre;

        bool _hombre;
        bool _mujer;

        bool _alto;
        bool _listo;
        bool _raro;
        bool _feo;
        bool _extravagante;
        bool _grande;
        string _critica;
        #endregion
        #region CONSTRUCTOR
        public VMcritico(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Nombre
        {
            get { return _nombre; }
            set { SetValue(ref _nombre, value); }
        }
        public bool Hombre
        {
            get { return _hombre; }
            set { SetValue(ref _hombre, value); }
        }
        public bool Mujer
        {
            get { return _mujer; }
            set { SetValue(ref _mujer, value); }
        }

        public bool Alto
        {
            get { return _alto; }
            set { SetValue(ref _alto, value); }
        }
        public bool Listo
        {
            get { return _listo; }
            set { SetValue(ref _listo, value); }
        }
        public bool Raro 
        {
            get { return _raro; }
            set { SetValue(ref _raro, value); }
        }
        public bool Feo
        {
            get { return _feo; }
            set { SetValue(ref _feo, value); }
        }
        public bool Extravagante
        {
            get { return _extravagante; }
            set { SetValue(ref _extravagante, value); }
        }
        public bool Grande
        {
            get { return _grande; }
            set { SetValue(ref _grande, value); }
        }
        public string Critica
        {
            get { return _critica; }
            set { SetValue(ref _critica, value); }
        }
        #endregion
        #region PROCESOS
        public async Task CriticarPersona()
        {
            StringBuilder criticaBuilder = new StringBuilder();

            criticaBuilder.Append($"{Nombre} es ");

            string genero = Hombre ? "hombre" : "mujer";
            string letraTransformada = (genero == "mujer") ? "a" : "o";

            List<string> caracteristicas = new List<string>();

            if (Alto)
                caracteristicas.Add($"alt{letraTransformada}");
            if (Listo)
                caracteristicas.Add($"list{letraTransformada}");
            if (Raro)
                caracteristicas.Add($"rar{letraTransformada}");
            if (Feo)
                caracteristicas.Add($"fe{letraTransformada}");
            if (Extravagante)
                caracteristicas.Add("extravagante");
            if (Grande)
                caracteristicas.Add("grande");

            for (int i = 0; i < caracteristicas.Count; i++)
            {
                if (i == caracteristicas.Count - 1)
                {
                    criticaBuilder.Append($"y {caracteristicas[i]}");
                }
                else
                {
                    criticaBuilder.Append($"{caracteristicas[i]}, ");
                }
            }
            criticaBuilder.Append(".");
            Critica = criticaBuilder.ToString();

        }
        public void CalcularTriangulo()
        {
            
        }
        #endregion
        #region COMANDOS
        //Esto es lo que ocupo para darle funcion al boton
        public ICommand ProcesoAsyncommand => new Command(async () => await CriticarPersona());
        public ICommand CalcularCommand => new Command(CalcularTriangulo);
        #endregion
    }
}
