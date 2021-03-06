#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;

namespace SampleBrowser
{
    internal class ScheduleLocalViewModel
    {
        internal ScheduleLocalViewModel()
        {
        }

        internal List<string> EnglishCollection { get; set; }

        internal void SetEnglishCollectionSubjects()
        {
            EnglishCollection = new List<string>();
            EnglishCollection.Add("GoToMeeting");
            EnglishCollection.Add("Business Meeting");
            EnglishCollection.Add("Conference");
            EnglishCollection.Add("Project Status Discussion");
            EnglishCollection.Add("Auditing");
            EnglishCollection.Add("Client Meeting");
            EnglishCollection.Add("Generate Report");
            EnglishCollection.Add("Target Meeting");
            EnglishCollection.Add("General Meeting");
            EnglishCollection.Add("Pay House Rent");
            EnglishCollection.Add("Car Service");
            EnglishCollection.Add("Medical Check Up");
            EnglishCollection.Add("Wedding Anniversary");
            EnglishCollection.Add("Sam's Birthday");
            EnglishCollection.Add("Jenny's Birthday");
            EnglishCollection.Add("Master Checkup");
            EnglishCollection.Add("Hospital");
            EnglishCollection.Add("Phone Bill Payment");
            EnglishCollection.Add("Project Plan");
            EnglishCollection.Add("Auditing");
            EnglishCollection.Add("Client Meeting");
            EnglishCollection.Add("Generate Report");
            EnglishCollection.Add("Target Meeting");
            EnglishCollection.Add("General Meeting");
            EnglishCollection.Add("Play Golf");
            EnglishCollection.Add("Car Service");
            EnglishCollection.Add("Medical Check Up");
            EnglishCollection.Add("Mary's Birthday");
            EnglishCollection.Add("John's Birthday");
            EnglishCollection.Add("Micheal's Birthday");
        }

        internal List<string> FrenchCollection { get; set; }

        internal void SetFrenchCollectionSubjects()
        {
            FrenchCollection = new List<string>();
            FrenchCollection.Add("aller ??? la r??union");
            FrenchCollection.Add("Un rendez-vous d'affaire");
            FrenchCollection.Add("Conf??rence");
            FrenchCollection.Add("Discussion Projet de Statut");
            FrenchCollection.Add("audit");
            FrenchCollection.Add("R??union du client");
            FrenchCollection.Add("g??n??rer un rapport");
            FrenchCollection.Add("R??union cible");
            FrenchCollection.Add("Assembl??e g??n??rale");
            FrenchCollection.Add("Pay Maison Louer");
            FrenchCollection.Add("Service automobile");
            FrenchCollection.Add("Visite m??dicale");
            FrenchCollection.Add("Anniversaire de mariage");
            FrenchCollection.Add("Anniversaire de Sam");
            FrenchCollection.Add("Anniversaire de Jenny");
            FrenchCollection.Add("Checkup Master");
            FrenchCollection.Add("H??pital");
            FrenchCollection.Add("T??l??phone paiement de factures");
            FrenchCollection.Add("Plan de projet");
            FrenchCollection.Add("audit");
            FrenchCollection.Add("R??union du client");
            FrenchCollection.Add("g??n??rer un rapport");
            FrenchCollection.Add("R??union cible");
            FrenchCollection.Add("Assembl??e g??n??rale");
            FrenchCollection.Add("Jouer au golf");
            FrenchCollection.Add("Service automobile");
            FrenchCollection.Add("Visite m??dicale");
            FrenchCollection.Add("Anniversaire de Marie");
            FrenchCollection.Add("Anniversaire de John");
            FrenchCollection.Add("Anniversaire de Micheal");
        }

        internal List<string> SpanishCollection { get; set; }

        internal void SetSpanishCollectionSubjects()
        {
            SpanishCollection = new List<string>();
            SpanishCollection.Add("Ir a la reuni??n");
            SpanishCollection.Add("Reuni??n de negocios");
            SpanishCollection.Add("Conferencia");
            SpanishCollection.Add("Situaci??n del proyecto Discusi??n");
            SpanishCollection.Add("Auditor??a");
            SpanishCollection.Add("Reuni??n Cliente");
            SpanishCollection.Add("Generar informe");
            SpanishCollection.Add("Reuni??n Target");
            SpanishCollection.Add("Reuni??n general");
            SpanishCollection.Add("Pago Casa Alquilar");
            SpanishCollection.Add("Servicio de auto");
            SpanishCollection.Add("Revisi??n m??dica");
            SpanishCollection.Add("Aniversario de bodas");
            SpanishCollection.Add("Cumplea??os de Sam");
            SpanishCollection.Add("El cumplea??os de Jenny");
            SpanishCollection.Add("Chequeo Maestro");
            SpanishCollection.Add("el Hospital");
            SpanishCollection.Add("Tel??fono pago de facturas");
            SpanishCollection.Add("Plan de proyecto");
            SpanishCollection.Add("Auditor??a");
            SpanishCollection.Add("Reuni??n Cliente");
            SpanishCollection.Add("Generar informe");
            SpanishCollection.Add("Reuni??n Target");
            SpanishCollection.Add("Reuni??n general");
            SpanishCollection.Add("Jugar golf");
            SpanishCollection.Add("Servicio de auto");
            SpanishCollection.Add("Revisi??n m??dica");
            SpanishCollection.Add("Cumplea??os de Mar??a");
            SpanishCollection.Add("John Cumplea??os");
            SpanishCollection.Add("El cumplea??os de Micheal");
        }

        internal List<string> ChineseCollection { get; set; }

        internal void SetChineseCollectionSubjects()
        {
            ChineseCollection = new List<string>();
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("??????");
            ChineseCollection.Add("??????????????????");
            ChineseCollection.Add("??????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("??????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("???????????????");
            ChineseCollection.Add("???????????????");
            ChineseCollection.Add("???????????????");
            ChineseCollection.Add("??????");
            ChineseCollection.Add("??????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("??????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("??????");
            ChineseCollection.Add("???????????????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("????????????");
            ChineseCollection.Add("???????????????");
            ChineseCollection.Add("???????????????");
            ChineseCollection.Add("??????????????????");
        }

        // adding colors collection
        internal List<UIColor> ColorCollection { get; set; }

        internal void SetColors()
        {
            ColorCollection = new List<UIColor>();
            ColorCollection.Add(UIColor.FromRGB(0xA2, 0xC1, 0x39));
            ColorCollection.Add(UIColor.FromRGB(0xD8, 0x00, 0x73));
            ColorCollection.Add(UIColor.FromRGB(0x1B, 0xA1, 0xE2));
            ColorCollection.Add(UIColor.FromRGB(0xE6, 0x71, 0xB8));
            ColorCollection.Add(UIColor.FromRGB(0xF0, 0x96, 0x09));
            ColorCollection.Add(UIColor.FromRGB(0x33, 0x99, 0x33));
            ColorCollection.Add(UIColor.FromRGB(0x00, 0xAB, 0xA9));
            ColorCollection.Add(UIColor.FromRGB(0xE6, 0x71, 0xB8));
            ColorCollection.Add(UIColor.FromRGB(0x1B, 0xA1, 0xE2));
            ColorCollection.Add(UIColor.FromRGB(0xD8, 0x00, 0x73));
            ColorCollection.Add(UIColor.FromRGB(0xA2, 0xC1, 0x39));
            ColorCollection.Add(UIColor.FromRGB(0xD8, 0x00, 0x73));
            ColorCollection.Add(UIColor.FromRGB(0x33, 0x99, 0x33));
            ColorCollection.Add(UIColor.FromRGB(0xE6, 0x71, 0xB8));
            ColorCollection.Add(UIColor.FromRGB(0x00, 0xAB, 0xA9));
        }
    }
}