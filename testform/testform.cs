using openTRANS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static openTRANS.Common;

namespace testform
{
    public partial class testform : Form
    {
        public testform()
        {
            InitializeComponent();
        }

        private void testform_Load(object sender, EventArgs e)
        {
            NumberFormatInfo nfi = new NumberFormatInfo(); //English comma separator dot, e.g. for German systems
            nfi.NumberDecimalSeparator = ".";

            var o = new Order();
            
            o.OrderHeader.OrderInfo.DeliveryDate.Type = DeliveryDateType.Fixed;
            o.OrderHeader.OrderInfo.DeliveryDate.DeliveryStartDate = DateTime.Now.Date.AddDays(3);
            o.OrderHeader.OrderInfo.DeliveryDate.DeliveryEndDate = DateTime.Now.Date.AddDays(4);

            o.OrderHeader.ControlInfo.GeneratorInfo = "DXSdata openTRANS Generator";
            o.OrderHeader.ControlInfo.GenerationDate = DateTime.Now;

            o.OrderHeader.OrderInfo.OrderId = "123";
            o.OrderHeader.OrderInfo.OrderDate = DateTime.Now.Date;

            var p1 = new Party();
            p1.PartyId.Value = "TestSupplier";
            p1.PartyId.Type = PartyType.BuyerSpecific;
            p1.PartyRole = PartyRole.Supplier;

            var p2 = new Party();
            p2.PartyId.Value = "MyCustomerNumberOfSupplier";
            p2.PartyId.Type = PartyType.SupplierSpecific;
            p2.PartyRole = PartyRole.Buyer;

            p2.Address.Name = "MyCompany";
            p2.Address.ContactDetails.ContactName = "MyEmployee";
            p2.Address.Street = "MyStreet";
            p2.Address.Zip = "MyZipCode";
            p2.Address.City = "MyCity";
            p2.Address.Country = "Austria";
            p2.Address.Phone.Value = "+1234";
            p2.Address.Phone.Value = PhoneType.Office;
            p2.Address.Fax.Value = "+5678";
            p2.Address.Fax.Type = PhoneType.Office;
            p2.Address.Email = "me@example.com";

            var p3 = new Party();
            p3.PartyId.Value = "MyCustomerNumberOfSupplier";
            p3.PartyId.Type = PartyType.ERPlusSpecific;
            p3.PartyRole = PartyRole.Delivery;
            p3.Address.Name = "MyDeliveryAddress";
            p3.Address.Street = "MyDeliveryAddress";
            p3.Address.Zip = "MyDeliveryAddress";
            p3.Address.City = "MyDeliveryAddress";

            o.OrderHeader.OrderInfo.Parties.AddRange(new[] { p1, p2, p3 });

            o.OrderHeader.OrderInfo.OrderPartiesReference.BuyerIdRef.Value = "MyCustomerNumberOfSupplier";
            o.OrderHeader.OrderInfo.OrderPartiesReference.BuyerIdRef.Type = PartyType.SupplierSpecific;
            o.OrderHeader.OrderInfo.OrderPartiesReference.SupplierIdRef.Value = "TestSupplier";
            o.OrderHeader.OrderInfo.OrderPartiesReference.SupplierIdRef.Type = PartyType.BuyerSpecific;
            o.OrderHeader.OrderInfo.OrderPartiesReference.ShipmentPartiesReference.DeliveryIdRef.Value = "MyCustomerNumberOfSupplier";
            o.OrderHeader.OrderInfo.OrderPartiesReference.ShipmentPartiesReference.DeliveryIdRef.Type = PartyType.SupplierSpecific;

            //foreach (var pos in myOrderPositions)
            {
                var oi = new OrderItem();
                oi.LineItemId = "001";
                oi.ProductId.SupplierPid = "testnr";
                oi.ProductId.BuyerPid.Value = "testnr";
                oi.ProductId.DescriptionShort = "testdescription";

                var features = new List<(string fname, string fval, string funit)>();
                features.Add(("ColorCodeInside", "a", null));
                features.Add(("ColorCodeOutside", "b", null));
                features.Add(("Length", "3,12".ToString(nfi), "mm"));
                features.Add(("Width", "4", "mm"));
                features.Add(("Height", "6", "mm"));

                foreach (var feature in features)
                {
                    if (!string.IsNullOrWhiteSpace(feature.fval))
                    {
                        var f = new Feature();
                        f.FName = feature.fname;
                        f.FValue = feature.fval;
                        f.FUnit = feature.funit;
                        oi.ProductFeatures.Add(f);
                    }
                }

                oi.Quantity = 13;
                oi.OrderUnit = "mm".
                    Replace("mm", OrderUnit.Millimeter).
                    Replace("stk", OrderUnit.Piece).
                    Replace("stg", OrderUnit.Piece);

                oi.ProductPriceFix.PriceAmount = 14;
                //oi.ProductPriceFix.AllowOrChargesFix.AllowOrCharge.Type = AllowOrChargeTypes.Allowance;

                o.OrderItemList.Add(oi);
            }

            var ot = new XmlCreator(o);
            textBox1.Text = ot.Result;
        }
    }
}
