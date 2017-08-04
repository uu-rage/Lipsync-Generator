/*
  Copyright 2016 Utrecht University http://www.uu.nl/
   
  This software has been created in the context of the EU-funded RAGE project.
  Realising and Applied Gaming Eco-System (RAGE), Grant agreement No 644187,
  http://rageproject.eu/
 
  Lip Sync Generator
 
  Created by: Christyowidiasmoro, Utrecht University <c.christyowidiasmoro@uu.nl>
 
  For more information, contact Dr. Zerrin YUMAK, Email: z.yumak@uu.nl Web: http://www.zerrinyumak.com/
  https://www.staff.science.uu.nl/~yumak001/UUVHC/index.html
*/

// <copyright file="RageLipSyncGenerator.cs" company="RAGE">
// Copyright (c) 2016 RAGE All rights reserved.
// </copyright>
// <author>Chris021</author>
// <date>12/5/2016 11:53:54 AM</date>
// <summary>Implements the RageLipSyncGenerator class</summary>
namespace AssetPackage
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Xml;
    using System.IO;

    using AssetManagerPackage;
    using LipSyncGenerator;

    /// <summary>
    /// An LipSyncGenerator Rage asset
    /// </summary>
    public class RageLipSyncGenerator : BaseAsset
    {
        #region Fields

        /// <summary>
        /// Options for controlling the operation.
        /// </summary>
        private RageLipSyncGeneratorSettings settings = null;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the RageLipSyncGenerator.Asset class.
        /// </summary>
        public RageLipSyncGenerator()
            : base()
        {
            //! Create Settings and let it's BaseSettings class assign Defaultvalues where it can.
            // 
            settings = new RageLipSyncGeneratorSettings();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets options for controlling the operation.
        /// </summary>
        ///
        /// <remarks>   Besides the toXml() and fromXml() methods, we never use this property but use
        ///                it's correctly typed backing field 'settings' instead. </remarks>
        /// <remarks> This property should go into each asset having Settings of its own. </remarks>
        /// <remarks>   The actual class used should be derived from BaseAsset (and not directly from
        ///             ISetting). </remarks>
        ///
        /// <value>
        /// The settings.
        /// </value>
        public override ISettings Settings
        {
            get
            {
                return settings;
            }
            set
            {
                settings = (value as RageLipSyncGeneratorSettings);
            }
        }

        #endregion Methods
    }
}