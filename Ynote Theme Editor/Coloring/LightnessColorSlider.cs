﻿using System;
using System.ComponentModel;
using System.Drawing;

#if USEEXTERNALCYOTEKLIBS
using Cyotek.Drawing;
#endif

namespace Cyotek.Windows.Forms
{
    // Cyotek Color Picker controls library
    // Copyright © 2013 Cyotek. All Rights Reserved.
    // http://cyotek.com/blog/tag/colorpicker

    // If you use this code in your applications, donations or attribution are welcome

    public class LightnessColorSlider : ColorSlider, IColorEditor
    {
        #region Instance Fields

        private Color _color;

        #endregion

        #region Constructors

        public LightnessColorSlider()
        {
            BarStyle = ColorBarStyle.TwoColor;
            Color = Color.Black;
        }

        #endregion

        #region Events

        /// <summary>
        ///     Occurs when the Color property value changes
        /// </summary>
        [Category("Property Changed")]
        public event EventHandler ColorChanged;

        #endregion

        #region Overridden Properties

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override ColorBarStyle BarStyle
        {
            get { return base.BarStyle; }
            set { base.BarStyle = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color Color1
        {
            get { return base.Color1; }
            set { base.Color1 = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color Color2
        {
            get { return base.Color2; }
            set { base.Color2 = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color Color3
        {
            get { return base.Color3; }
            set { base.Color3 = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override float Maximum
        {
            get { return base.Maximum; }
            set { base.Maximum = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override float Minimum
        {
            get { return base.Minimum; }
            set { base.Minimum = value; }
        }

        public override float Value
        {
            get { return base.Value; }
            set { base.Value = (int) value; }
        }

        #endregion

        #region Properties

        [Category("Appearance")]
        [DefaultValue(typeof (Color), "Black")]
        public virtual Color Color
        {
            get { return _color; }
            set
            {
                if (Color != value)
                {
                    _color = value;

                    OnColorChanged(EventArgs.Empty);
                }
            }
        }

        #endregion

        #region Members

        protected virtual void CreateScale()
        {
            HslColor color;

            color = new HslColor(Color);

            color.L = 0;
            Color1 = color.ToRgbColor();

            color.L = 1;
            Color2 = color.ToRgbColor();
        }

        /// <summary>
        ///     Raises the <see cref="ColorChanged" /> event.
        /// </summary>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        protected virtual void OnColorChanged(EventArgs e)
        {
            EventHandler handler;

            CreateScale();
            Invalidate();

            handler = ColorChanged;

            if (handler != null)
                handler(this, e);
        }

        #endregion
    }
}