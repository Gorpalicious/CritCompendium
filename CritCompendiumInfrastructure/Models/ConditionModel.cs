﻿using System.Collections.Generic;

namespace CritCompendiumInfrastructure.Models
{
   public sealed class ConditionModel : CompendiumEntryModel
   {
      #region Fields

      private string _description;
      private int _levels;
      private List<string> _headers = new List<string>();
      private List<string> _elements = new List<string>();
      private List<string> _textCollection = new List<string>();
      private string _xml;

      #endregion

      #region Constructors

      /// <summary>
      /// Creates a default instance of <see cref="ConditionModel"/>
      /// </summary>
      public ConditionModel()
      {
      }

      /// <summary>
      /// Creates a copy of <see cref="ConditionModel"/>
      /// </summary>
      public ConditionModel(ConditionModel conditionModel) : base(conditionModel)
      {
         _description = conditionModel.Description;
         _levels = conditionModel.Levels;
         _headers = new List<string>(conditionModel.Headers);
         _elements = new List<string>(conditionModel.Elements);
         _textCollection = new List<string>(conditionModel.TextCollection);

         _xml = conditionModel.XML;
      }

      #endregion

      #region Properties

      /// <summary>
      /// Gets or sets description
      /// </summary>
      public string Description
      {
         get { return _description; }
         set { _description = value; }
      }

      /// <summary>
      /// Gets or sets levels
      /// </summary>
      public int Levels
      {
         get { return _levels; }
         set { _levels = value; }
      }

      /// <summary>
      /// Gets or sets headers
      /// </summary>
      public List<string> Headers
      {
         get { return _headers; }
         set { _headers = value; }
      }

      /// <summary>
      /// Gets or sets elements
      /// </summary>
      public List<string> Elements
      {
         get { return _elements; }
         set { _elements = value; }
      }

      /// <summary>
      /// Gets or sets text
      /// </summary>
      public List<string> TextCollection
      {
         get { return _textCollection; }
         set { _textCollection = value; }
      }

      /// <summary>
      /// Gets or sets xml
      /// </summary>
      public string XML
      {
         get { return _xml; }
         set { _xml = value; }
      }

      #endregion
   }
}
