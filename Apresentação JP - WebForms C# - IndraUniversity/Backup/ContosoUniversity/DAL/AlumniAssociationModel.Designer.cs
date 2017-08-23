﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM Relationship Metadata

[assembly: EdmRelationshipAttribute("AlumniAssociationModel", "AlumnusDonation", "Alumnus", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(ContosoUniversity.DAL.Alumnus), "Donation", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(ContosoUniversity.DAL.Donation), true)]

#endregion

namespace ContosoUniversity.DAL
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class AlumniAssociationModelContainer : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new AlumniAssociationModelContainer object using the connection string found in the 'AlumniAssociationModelContainer' section of the application configuration file.
        /// </summary>
        public AlumniAssociationModelContainer() : base("name=AlumniAssociationModelContainer", "AlumniAssociationModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AlumniAssociationModelContainer object.
        /// </summary>
        public AlumniAssociationModelContainer(string connectionString) : base(connectionString, "AlumniAssociationModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new AlumniAssociationModelContainer object.
        /// </summary>
        public AlumniAssociationModelContainer(EntityConnection connection) : base(connection, "AlumniAssociationModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Alumnus> Alumni
        {
            get
            {
                if ((_Alumni == null))
                {
                    _Alumni = base.CreateObjectSet<Alumnus>("Alumni");
                }
                return _Alumni;
            }
        }
        private ObjectSet<Alumnus> _Alumni;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<Donation> Donations
        {
            get
            {
                if ((_Donations == null))
                {
                    _Donations = base.CreateObjectSet<Donation>("Donations");
                }
                return _Donations;
            }
        }
        private ObjectSet<Donation> _Donations;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Alumni EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToAlumni(Alumnus alumnus)
        {
            base.AddObject("Alumni", alumnus);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the Donations EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToDonations(Donation donation)
        {
            base.AddObject("Donations", donation);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AlumniAssociationModel", Name="Alumnus")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Alumnus : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Alumnus object.
        /// </summary>
        /// <param name="alumnusId">Initial value of the AlumnusId property.</param>
        /// <param name="name">Initial value of the Name property.</param>
        public static Alumnus CreateAlumnus(global::System.Int32 alumnusId, global::System.String name)
        {
            Alumnus alumnus = new Alumnus();
            alumnus.AlumnusId = alumnusId;
            alumnus.Name = name;
            return alumnus;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AlumnusId
        {
            get
            {
                return _AlumnusId;
            }
            set
            {
                if (_AlumnusId != value)
                {
                    OnAlumnusIdChanging(value);
                    ReportPropertyChanging("AlumnusId");
                    _AlumnusId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("AlumnusId");
                    OnAlumnusIdChanged();
                }
            }
        }
        private global::System.Int32 _AlumnusId;
        partial void OnAlumnusIdChanging(global::System.Int32 value);
        partial void OnAlumnusIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Name
        {
            get
            {
                return _Name;
            }
            set
            {
                OnNameChanging(value);
                ReportPropertyChanging("Name");
                _Name = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Name");
                OnNameChanged();
            }
        }
        private global::System.String _Name;
        partial void OnNameChanging(global::System.String value);
        partial void OnNameChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AlumniAssociationModel", "AlumnusDonation", "Donation")]
        public EntityCollection<Donation> Donations
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Donation>("AlumniAssociationModel.AlumnusDonation", "Donation");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Donation>("AlumniAssociationModel.AlumnusDonation", "Donation", value);
                }
            }
        }

        #endregion
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="AlumniAssociationModel", Name="Donation")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Donation : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new Donation object.
        /// </summary>
        /// <param name="donationId">Initial value of the DonationId property.</param>
        /// <param name="dateAndAmount">Initial value of the DateAndAmount property.</param>
        /// <param name="alumnusAlumnusId">Initial value of the AlumnusAlumnusId property.</param>
        public static Donation CreateDonation(global::System.Int32 donationId, global::System.String dateAndAmount, global::System.Int32 alumnusAlumnusId)
        {
            Donation donation = new Donation();
            donation.DonationId = donationId;
            donation.DateAndAmount = dateAndAmount;
            donation.AlumnusAlumnusId = alumnusAlumnusId;
            return donation;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DonationId
        {
            get
            {
                return _DonationId;
            }
            set
            {
                if (_DonationId != value)
                {
                    OnDonationIdChanging(value);
                    ReportPropertyChanging("DonationId");
                    _DonationId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DonationId");
                    OnDonationIdChanged();
                }
            }
        }
        private global::System.Int32 _DonationId;
        partial void OnDonationIdChanging(global::System.Int32 value);
        partial void OnDonationIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DateAndAmount
        {
            get
            {
                return _DateAndAmount;
            }
            set
            {
                OnDateAndAmountChanging(value);
                ReportPropertyChanging("DateAndAmount");
                _DateAndAmount = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DateAndAmount");
                OnDateAndAmountChanged();
            }
        }
        private global::System.String _DateAndAmount;
        partial void OnDateAndAmountChanging(global::System.String value);
        partial void OnDateAndAmountChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 AlumnusAlumnusId
        {
            get
            {
                return _AlumnusAlumnusId;
            }
            set
            {
                OnAlumnusAlumnusIdChanging(value);
                ReportPropertyChanging("AlumnusAlumnusId");
                _AlumnusAlumnusId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("AlumnusAlumnusId");
                OnAlumnusAlumnusIdChanged();
            }
        }
        private global::System.Int32 _AlumnusAlumnusId;
        partial void OnAlumnusAlumnusIdChanging(global::System.Int32 value);
        partial void OnAlumnusAlumnusIdChanged();

        #endregion
    
        #region Navigation Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("AlumniAssociationModel", "AlumnusDonation", "Alumnus")]
        public Alumnus Alumnus
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Alumnus>("AlumniAssociationModel.AlumnusDonation", "Alumnus").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Alumnus>("AlumniAssociationModel.AlumnusDonation", "Alumnus").Value = value;
            }
        }
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Alumnus> AlumnusReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Alumnus>("AlumniAssociationModel.AlumnusDonation", "Alumnus");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Alumnus>("AlumniAssociationModel.AlumnusDonation", "Alumnus", value);
                }
            }
        }

        #endregion
    }

    #endregion
    
}
