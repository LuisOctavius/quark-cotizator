using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using qk_cotiztr.Enums;
using qk_cotiztr.Models;
using qk_cotiztr.Views;
using qk_cotiztr.ViewModels;

namespace qk_cotiztr.Controllers
{
    public class CotizationsController
    {
        readonly ViewMain _view;
        private readonly Store _store;
        private readonly List<Cotization> _cotizations;
        Cotization _currentCotization;

        public CotizationsController(ViewMain view)
        {
            _view = view;

            _store = new Store()
            {
                Name = "Arthur's Shop",
                Address = "Gascón 1460",
                GarmentsOnSale = new List<Garment>()
                {
                    new Shirt("Cuello mao manga corta", 100, 100, QualityType.Standard, NeckType.Mandarin, SleeveType.Short),
                    new Shirt("Cuello mao manga corta", 100, 100, QualityType.Premium, NeckType.Mandarin, SleeveType.Short),
                    new Shirt("Cuello comun manga corta", 100, 150, QualityType.Standard, NeckType.Classic, SleeveType.Short),
                    new Shirt("Cuello comun manga corta", 100, 150, QualityType.Premium, NeckType.Classic, SleeveType.Short),
                    new Shirt("Cuello mao manga larga", 100, 75, QualityType.Standard, NeckType.Mandarin, SleeveType.Long),
                    new Shirt("Cuello mao manga larga", 100, 75, QualityType.Premium, NeckType.Mandarin, SleeveType.Long),
                    new Shirt("Cuello comun manga larga", 100, 175, QualityType.Standard, NeckType.Classic, SleeveType.Long),
                    new Shirt("Cuello comun manga larga", 100, 175, QualityType.Premium, NeckType.Classic, SleeveType.Long),
                    new Pants("Chupin", 100, 750, QualityType.Standard, PantsType.Chupin),
                    new Pants("Chupin", 100, 750, QualityType.Premium, PantsType.Chupin),
                    new Pants("Comun", 100, 250, QualityType.Standard, PantsType.Common),
                    new Pants("Comun", 100, 250, QualityType.Premium, PantsType.Common)
                },
                Vendor = new Vendor()
                {
                    Id = 404,
                    Name = "John",
                    Surname = "Doe"
                }
            };
            _cotizations = new List<Cotization>();

            //Events
            _view.Load += Event_SetStoreData;
            _view.Load += Event_SetVendorData;
            _view.Load += Event_ShowGarments;
            _view.comboBox_Garments.SelectedIndexChanged += Event_SelectedGarment;
            _view.checkBox_PremiumQuality.CheckedChanged += Event_GarmentQualityChanged;
            _view.listBox_GarmentVariants.SelectedIndexChanged += Event_SelectedGarmentVariant;
            _view.Btn_GenerateCotization.Click += Event_GenerateCotization;
            _view.LinkLabel_VendorCotizations.LinkClicked += Event_ShowVendorCotizations;
        }

        private Cotization AddCotization(Garment garment, decimal total)
        {
            Cotization cotization = new Cotization(Guid.NewGuid(), DateTime.Now, _store.Vendor.Id, garment, total);

            _cotizations.Add(cotization);

            return cotization;
        }

        private void Event_SetVendorData(object sender, EventArgs e)
        {
            _view.Label_VendorInfo.Text = $"{_store.Vendor.Name} {_store.Vendor.Surname} | #{_store.Vendor.Id}";
        }

        private void Event_SetStoreData(object sender, EventArgs e)
        {
            _view.Label_StoreName.Text = _store.Name;
            _view.Label_StoreAddress.Text = _store.Address;
        }

        private void Event_ShowGarments(object sender, EventArgs e)
        {
            var groupedGarmentTypes = _store.GarmentsOnSale
                .GroupBy(x => x.Type)
                .Select(s => s.Key)
                .ToList();

            _view.comboBox_Garments.DataSource = groupedGarmentTypes;
            _view.comboBox_Garments.DisplayMember = "Name";

        }

        private void Event_SelectedGarment(object sender, EventArgs e)
        {
            ComboBox cmb = sender as ComboBox;

            _view.listBox_GarmentVariants.DataSource = null;
            _view.listBox_GarmentVariants.Items.Clear();

            if (cmb.DroppedDown)
            {
                _view.listBox_GarmentVariants.Enabled = false;
                return;
            }

            LoadGarmentVariants();
        }

        private void LoadGarmentVariants()
        {
            var selectedGarmentType = (GarmentType)_view.comboBox_Garments.SelectedItem;
            var selectedQuality = _view.checkBox_PremiumQuality.Checked ? QualityType.Premium : QualityType.Standard;

            var variants = _store.GarmentsOnSale
                .Where(x => x.Type == selectedGarmentType && x.Quality == selectedQuality)
                .Select(x => new
                {
                    Text = x.Name,
                    Value = x
                })
                .ToList();

            _view.listBox_GarmentVariants.Enabled = true;
            _view.listBox_GarmentVariants.DisplayMember = "Text";
            _view.listBox_GarmentVariants.ValueMember = "Value";

            _view.listBox_GarmentVariants.DataSource = variants;
        }

        private void Event_GarmentQualityChanged(object sender, EventArgs e)
        {
            LoadGarmentVariants();
        }

        private void Event_SelectedGarmentVariant(object sender, EventArgs e)
        {
            ListBox variants = sender as ListBox;

            var selectedVariant = (Garment)variants.SelectedValue;

            if (selectedVariant is null) return;

            _view.label_AvailableStockInfoData.Text = $"{selectedVariant.Stock} - {selectedVariant.Quality}";
        }

        private void Event_GenerateCotization(object sender, EventArgs e)
        {
            try
            {
                ResetCurrentCotization();

                if (!ValidateCotization()) return;

                var selectedVariant = (Garment)_view.listBox_GarmentVariants.SelectedValue;
                var selectedQuantity = int.Parse(_view.textBox_CotizationQuantity.Text);

                var total = Convert.ToDecimal(selectedVariant.Price * selectedQuantity);

                _currentCotization = AddCotization(selectedVariant, total);

                _view.label_CotizationResult.Text = $"Precio: {_currentCotization.Total:C2}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected exception occured while generating the current cotization: { ex.Message }", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateCotization()
        {
            var selectedVariant = (Garment)_view.listBox_GarmentVariants.SelectedValue;
            bool hasValidQuantity = int.TryParse(_view.textBox_CotizationQuantity.Text, out var selectedQuantity);
            bool status = false;

            if (selectedVariant == null)
            {
                MessageBox.Show("Necesitas seleccionar una prenda para poder cotizarla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return status;
            }

            if (!hasValidQuantity || hasValidQuantity && selectedQuantity < 1)
            {
                MessageBox.Show("La cantidad ingresada no es válida, debe ser numérica y mayor a cero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return status;
            }

            if (selectedVariant.Stock < selectedQuantity)
            {
                MessageBox.Show($"Tu cantidad a cotizar supera el stock disponible, volve a intentarlo con un máximo de { selectedVariant.Stock } prendas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return status;
            }

            return !status;
        }

        private void ResetCurrentCotization()
        {
            _currentCotization = null;
            _view.label_CotizationResult.Text = "Precio: $ -";
        }

        private void Event_ShowVendorCotizations(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var cotizations = _cotizations.ConvertAll(x => new CotizationHistoryItem
            {
                Id = x.Id.ToString(),
                Prenda = x.Garment.Name,
                Tipo = x.Garment.Type.ToString(),
                Calidad = x.Garment.Quality.ToString(),
                Fecha = x.Created.ToString("dd/MM/yyyy"),
                Total = x.Total.ToString("C2")
            });

            var cotizationsHistory = new ViewCotizationHistory(cotizations);

            cotizationsHistory.ShowDialog();
        }

    }
}
