using System;
using System.Drawing;
using Grasshopper.Kernel;

namespace GrasshopperLayer
{
    public class GrasshopperLayerInfo : GH_AssemblyInfo
    {
        public override string Name
        {
            get
            {
                return "GrasshopperLayer";
            }
        }
        public override Bitmap Icon
        {
            get
            {
                //Return a 24x24 pixel bitmap to represent this GHA library.
                return null;
            }
        }
        public override string Description
        {
            get
            {
                //Return a short string describing the purpose of this GHA library.
                return "";
            }
        }
        public override Guid Id
        {
            get
            {
                return new Guid("42b424c3-fd7b-433c-b656-e350a707265a");
            }
        }

        public override string AuthorName
        {
            get
            {
                //Return a string identifying you or your company.
                return "";
            }
        }
        public override string AuthorContact
        {
            get
            {
                //Return a string representing your preferred contact details.
                return "";
            }
        }
    }
}
