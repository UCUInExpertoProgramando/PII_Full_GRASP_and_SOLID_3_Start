//---------------------------------------------------------------------------------
// <copyright file="AllInOnePrinter.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------
using System;
using System.IO;

namespace Full_GRASP_And_SOLID.Library
{
    //Creamos una interfaz, y utilizando el Polymorphism, que es parte del patrón GRASP, 
    //hicimos un método que hace cosas diferentes dependiendo de cuál subtipo de IPrinter lo utilice.
    public interface IPrinter
    {
        public void PrintRecipe(Recipe recipe);
    }
}
