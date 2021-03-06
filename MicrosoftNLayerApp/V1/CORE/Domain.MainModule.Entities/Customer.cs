//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Runtime.Serialization;

#pragma warning disable 1591 // this is for supress no xml comments in public members warnings 

using Microsoft.Samples.NLayerApp.Domain.Core.Entities;

namespace Microsoft.Samples.NLayerApp.Domain.MainModule.Entities
{
    [DataContract(IsReference = true)]
    [KnownType(typeof(BankAccount))]
    [KnownType(typeof(Country))]
    [KnownType(typeof(Order))]
    [KnownType(typeof(CustomerPicture))]
    [System.CodeDom.Compiler.GeneratedCode("STE-EF",".NET 4.0")]
    #if !SILVERLIGHT
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage()]
    #endif
    public partial class Customer: IObjectWithChangeTracker, INotifyPropertyChanged
    {
        #region Primitive Properties
    
        [DataMember]
        public int CustomerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    if (ChangeTracker.ChangeTrackingEnabled && ChangeTracker.State != ObjectState.Added)
                    {
                        throw new InvalidOperationException("The property 'CustomerId' is part of the object's key and cannot be changed. Changes to key properties can only be made when the object is not being tracked or is in the Added state.");
                    }
                    _customerId = value;
                    OnPropertyChanged("CustomerId");
                }
            }
        }
        private int _customerId;
    
        [DataMember]
        public string CustomerCode
        {
            get { return _customerCode; }
            set
            {
                if (_customerCode != value)
                {
                    _customerCode = value;
                    OnPropertyChanged("CustomerCode");
                }
            }
        }
        private string _customerCode;
    
        [DataMember]
        public string CompanyName
        {
            get { return _companyName; }
            set
            {
                if (_companyName != value)
                {
                    _companyName = value;
                    OnPropertyChanged("CompanyName");
                }
            }
        }
        private string _companyName;
    
        [DataMember]
        public string ContactName
        {
            get { return _contactName; }
            set
            {
                if (_contactName != value)
                {
                    _contactName = value;
                    OnPropertyChanged("ContactName");
                }
            }
        }
        private string _contactName;
    
        [DataMember]
        public string ContactTitle
        {
            get { return _contactTitle; }
            set
            {
                if (_contactTitle != value)
                {
                    _contactTitle = value;
                    OnPropertyChanged("ContactTitle");
                }
            }
        }
        private string _contactTitle;
    
        [DataMember]
        public Nullable<int> CountryId
        {
            get { return _countryId; }
            set
            {
                if (_countryId != value)
                {
                    ChangeTracker.RecordOriginalValue("CountryId", _countryId);
                    if (!IsDeserializing)
                    {
                        if (Country != null && Country.CountryId != value)
                        {
                            Country = null;
                        }
                    }
                    _countryId = value;
                    OnPropertyChanged("CountryId");
                }
            }
        }
        private Nullable<int> _countryId;
    
        [DataMember]
        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                if (_isEnabled != value)
                {
                    _isEnabled = value;
                    OnPropertyChanged("IsEnabled");
                }
            }
        }
        private bool _isEnabled;

        #endregion
        #region Complex Properties
    
        [DataMember]
        public AddressInformation Address
        {
            get
            {
                if (!_addressInitialized && _address == null)
                {
                    _address = new AddressInformation();
                    ((INotifyComplexPropertyChanging)_address).ComplexPropertyChanging += HandleAddressChanging;
                }
                _addressInitialized = true;
                return _address;
            }
            set
            {
                _addressInitialized = true;
                if (!Equals(_address, value))
                {
                    if (_address != null)
                    {
                        ((INotifyComplexPropertyChanging)_address).ComplexPropertyChanging -= HandleAddressChanging;
                    }
    
                    HandleAddressChanging(this, null);
                    _address = value;
                    OnPropertyChanged("Address");
    
                    if (value != null)
                    {
                        ((INotifyComplexPropertyChanging)_address).ComplexPropertyChanging += HandleAddressChanging;
                    }
                }
            }
        }
        private AddressInformation _address;
        private bool _addressInitialized;

        #endregion
        #region Navigation Properties
    
        [DataMember]
        public TrackableCollection<BankAccount> BankAccounts
        {
            get
            {
                if (_bankAccounts == null)
                {
                    _bankAccounts = new TrackableCollection<BankAccount>();
                    _bankAccounts.CollectionChanged += FixupBankAccounts;
                }
                return _bankAccounts;
            }
            set
            {
                if (!ReferenceEquals(_bankAccounts, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_bankAccounts != null)
                    {
                        _bankAccounts.CollectionChanged -= FixupBankAccounts;
                    }
                    _bankAccounts = value;
                    if (_bankAccounts != null)
                    {
                        _bankAccounts.CollectionChanged += FixupBankAccounts;
                    }
                    OnNavigationPropertyChanged("BankAccounts");
                }
            }
        }
        private TrackableCollection<BankAccount> _bankAccounts;
    
        [DataMember]
        public Country Country
        {
            get { return _country; }
            set
            {
                if (!ReferenceEquals(_country, value))
                {
                    var previousValue = _country;
                    _country = value;
                    FixupCountry(previousValue);
                    OnNavigationPropertyChanged("Country");
                }
            }
        }
        private Country _country;
    
        [DataMember]
        public TrackableCollection<Order> Orders
        {
            get
            {
                if (_orders == null)
                {
                    _orders = new TrackableCollection<Order>();
                    _orders.CollectionChanged += FixupOrders;
                }
                return _orders;
            }
            set
            {
                if (!ReferenceEquals(_orders, value))
                {
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        throw new InvalidOperationException("Cannot set the FixupChangeTrackingCollection when ChangeTracking is enabled");
                    }
                    if (_orders != null)
                    {
                        _orders.CollectionChanged -= FixupOrders;
                    }
                    _orders = value;
                    if (_orders != null)
                    {
                        _orders.CollectionChanged += FixupOrders;
                    }
                    OnNavigationPropertyChanged("Orders");
                }
            }
        }
        private TrackableCollection<Order> _orders;
    
        [DataMember]
        public CustomerPicture CustomerPicture
        {
            get { return _customerPicture; }
            set
            {
                if (!ReferenceEquals(_customerPicture, value))
                {
                    var previousValue = _customerPicture;
                    _customerPicture = value;
                    FixupCustomerPicture(previousValue);
                    OnNavigationPropertyChanged("CustomerPicture");
                }
            }
        }
        private CustomerPicture _customerPicture;

        #endregion
        #region ChangeTracking
    
        protected virtual void OnPropertyChanged(String propertyName)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        protected virtual void OnNavigationPropertyChanged(String propertyName)
        {
            if (_propertyChanged != null)
            {
                _propertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    
        event PropertyChangedEventHandler INotifyPropertyChanged.PropertyChanged{ add { _propertyChanged += value; } remove { _propertyChanged -= value; } }
        private event PropertyChangedEventHandler _propertyChanged;
        private ObjectChangeTracker _changeTracker;
    
        [DataMember]
        public ObjectChangeTracker ChangeTracker
        {
            get
            {
                if (_changeTracker == null)
                {
                    _changeTracker = new ObjectChangeTracker();
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
                return _changeTracker;
            }
            set
            {
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging -= HandleObjectStateChanging;
                }
                _changeTracker = value;
                if(_changeTracker != null)
                {
                    _changeTracker.ObjectStateChanging += HandleObjectStateChanging;
                }
            }
        }
    
        private void HandleObjectStateChanging(object sender, ObjectStateChangingEventArgs e)
        {
            if (e.NewState == ObjectState.Deleted)
            {
                ClearNavigationProperties();
            }
        }
    
        protected bool IsDeserializing { get; private set; }
    
        [OnDeserializing]
        public void OnDeserializingMethod(StreamingContext context)
        {
            IsDeserializing = true;
        }
    
        [OnDeserialized]
        public void OnDeserializedMethod(StreamingContext context)
        {
            IsDeserializing = false;
            ChangeTracker.ChangeTrackingEnabled = true;
        }
        // Records the original values for the complex property Address
        private void HandleAddressChanging(object sender, EventArgs args)
        {
            if (ChangeTracker.State != ObjectState.Added && ChangeTracker.State != ObjectState.Deleted)
            {
                ChangeTracker.State = ObjectState.Modified;
            }
        }
    
    
        protected virtual void ClearNavigationProperties()
        {
            BankAccounts.Clear();
            Country = null;
            Orders.Clear();
            CustomerPicture = null;
        }

        #endregion
        #region Association Fixup
    
        private void FixupCountry(Country previousValue, bool skipKeys = false)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && previousValue.Customers.Contains(this))
            {
                previousValue.Customers.Remove(this);
            }
    
            if (Country != null)
            {
                if (!Country.Customers.Contains(this))
                {
                    Country.Customers.Add(this);
                }
    
                CountryId = Country.CountryId;
            }
            else if (!skipKeys)
            {
                CountryId = null;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("Country")
                    && (ChangeTracker.OriginalValues["Country"] == Country))
                {
                    ChangeTracker.OriginalValues.Remove("Country");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("Country", previousValue);
                }
                if (Country != null && !Country.ChangeTracker.ChangeTrackingEnabled)
                {
                    Country.StartTracking();
                }
            }
        }
    
        private void FixupCustomerPicture(CustomerPicture previousValue)
        {
            // This is the principal end in an association that performs cascade deletes.
            // Update the event listener to refer to the new dependent.
            if (previousValue != null)
            {
                ChangeTracker.ObjectStateChanging -= previousValue.HandleCascadeDelete;
            }
    
            if (CustomerPicture != null)
            {
                ChangeTracker.ObjectStateChanging += CustomerPicture.HandleCascadeDelete;
            }
    
            if (IsDeserializing)
            {
                return;
            }
    
            if (previousValue != null && ReferenceEquals(previousValue.Customer, this))
            {
                previousValue.Customer = null;
            }
    
            if (CustomerPicture != null)
            {
                CustomerPicture.Customer = this;
            }
    
            if (ChangeTracker.ChangeTrackingEnabled)
            {
                if (ChangeTracker.OriginalValues.ContainsKey("CustomerPicture")
                    && (ChangeTracker.OriginalValues["CustomerPicture"] == CustomerPicture))
                {
                    ChangeTracker.OriginalValues.Remove("CustomerPicture");
                }
                else
                {
                    ChangeTracker.RecordOriginalValue("CustomerPicture", previousValue);
                    // This is the principal end of an identifying association, so the dependent must be deleted when the relationship is removed.
                    // If the current state of the dependent is Added, the relationship can be changed without causing the dependent to be deleted.
                    if (previousValue != null && previousValue.ChangeTracker.State != ObjectState.Added)
                    {
                        previousValue.MarkAsDeleted();
                    }
                }
                if (CustomerPicture != null && !CustomerPicture.ChangeTracker.ChangeTrackingEnabled)
                {
                    CustomerPicture.StartTracking();
                }
            }
        }
    
        private void FixupBankAccounts(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (BankAccount item in e.NewItems)
                {
                    item.Customer = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("BankAccounts", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (BankAccount item in e.OldItems)
                {
                    if (ReferenceEquals(item.Customer, this))
                    {
                        item.Customer = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("BankAccounts", item);
                    }
                }
            }
        }
    
        private void FixupOrders(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (IsDeserializing)
            {
                return;
            }
    
            if (e.NewItems != null)
            {
                foreach (Order item in e.NewItems)
                {
                    item.Customer = this;
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        if (!item.ChangeTracker.ChangeTrackingEnabled)
                        {
                            item.StartTracking();
                        }
                        ChangeTracker.RecordAdditionToCollectionProperties("Orders", item);
                    }
                }
            }
    
            if (e.OldItems != null)
            {
                foreach (Order item in e.OldItems)
                {
                    if (ReferenceEquals(item.Customer, this))
                    {
                        item.Customer = null;
                    }
                    if (ChangeTracker.ChangeTrackingEnabled)
                    {
                        ChangeTracker.RecordRemovalFromCollectionProperties("Orders", item);
                    }
                }
            }
        }

        #endregion
    }
}
