namespace ClassBox
{
    using System;
    using System.Text;

    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }

        public double Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArithmeticException("Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArithmeticException("Width cannot be zero or negative.");

                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArithmeticException("Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        private double CalculateSurfaceArea()
        {
            //2lw + 2lh + 2wh
            double surfaceArea = (2 * this.Length * this.Width) +
                                 (2 * this.Length * this.Height) +
                                 (2 * this.Width * this.Height);
            return surfaceArea;
        }

        private double CalculateLateralSurfaceArea()
        {
            //Lateral Surface Area = 2lh + 2wh
            double lateralSurfaceArea = (2 * this.Length * this.Height) +
                                        (2 * this.Width * this.Height);

            return lateralSurfaceArea;
        }

        private double CalculateVolume()
        {
            //Volume = lwh
            double volume = this.Length * this.Width * this.Height;

            return volume;
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();
            output.AppendLine($"Surface Area - {this.CalculateSurfaceArea():F2}");
            output.AppendLine($"Lateral Surface Area - {this.CalculateLateralSurfaceArea():F2}");
            output.AppendLine($"Volume - {this.CalculateVolume():F2}");

            return output.ToString();
        }
    }
}
