﻿// <auto-generated />
using System;
using ManageContacts.Entity.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManageContacts.Entity.Migrations
{
    [DbContext(typeof(ContactsContext))]
    partial class ContactsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ManageContacts.Entity.Entities.Address", b =>
                {
                    b.Property<Guid>("ContactAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("AddressTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Addresss")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("FormattedType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Province")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Type")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Ward")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("ContactAddressId");

                    b.HasIndex("AddressTypeId");

                    b.HasIndex("ContactId");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.AddressType", b =>
                {
                    b.Property<Guid>("AddressTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UnaccentedName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("AddressTypeId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ModifierId");

                    b.ToTable("AddressTypes");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Company", b =>
                {
                    b.Property<Guid>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Contact", b =>
                {
                    b.Property<Guid>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Note")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ContactId");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.EmailAddress", b =>
                {
                    b.Property<Guid>("ContactEmailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("EmailTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FormattedType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Type")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ContactEmailId");

                    b.HasIndex("ContactId");

                    b.HasIndex("EmailTypeId");

                    b.ToTable("EmailAddresses");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.EmailType", b =>
                {
                    b.Property<Guid>("EmailTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UnaccentedName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("EmailTypeId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ModifierId");

                    b.ToTable("EmailTypes");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Group", b =>
                {
                    b.Property<Guid>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("GroupId");

                    b.HasIndex("UserId");

                    b.ToTable("Groups");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.PhoneNumber", b =>
                {
                    b.Property<Guid>("ContactPhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FormattedType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("PhoneTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ContactPhoneId");

                    b.HasIndex("ContactId");

                    b.HasIndex("PhoneTypeId");

                    b.ToTable("PhoneNumbers");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.PhoneType", b =>
                {
                    b.Property<Guid>("PhoneTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UnaccentedName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("PhoneTypeId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ModifierId");

                    b.ToTable("PhoneTypes");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Relative", b =>
                {
                    b.Property<Guid>("ContactRelativeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ContactId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("FormattedType")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("RelativeTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Type")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("ContactRelativeId");

                    b.HasIndex("ContactId");

                    b.HasIndex("RelativeTypeId");

                    b.ToTable("Relatives");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.RelativeType", b =>
                {
                    b.Property<Guid>("RelativeTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("UnaccentedName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RelativeTypeId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ModifierId");

                    b.ToTable("RelativeTypes");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Role", b =>
                {
                    b.Property<Guid>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("RoleId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ModifierId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Avatar")
                        .IsUnicode(false)
                        .HasColumnType("varchar(max)");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Deleted")
                        .HasColumnType("bit");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("ModifiedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("ModifierId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("PasswordHashed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordSalt")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("UserId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("ModifierId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.UserRole", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CreatorId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("CreatorId");

                    b.HasIndex("RoleId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Address", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.AddressType", "AddressType")
                        .WithMany()
                        .HasForeignKey("AddressTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManageContacts.Entity.Entities.Contact", "Contact")
                        .WithMany("Addresses")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AddressType");

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.AddressType", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("ManageContacts.Entity.Entities.User", "Modifier")
                        .WithMany()
                        .HasForeignKey("ModifierId");

                    b.Navigation("Creator");

                    b.Navigation("Modifier");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Company", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.Contact", "Contact")
                        .WithOne("Company")
                        .HasForeignKey("ManageContacts.Entity.Entities.Company", "CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Contact", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.Group", "Group")
                        .WithMany("Contacts")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManageContacts.Entity.Entities.User", "User")
                        .WithMany("Contacts")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.EmailAddress", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.Contact", "Contact")
                        .WithMany("EmailAddresses")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManageContacts.Entity.Entities.EmailType", "EmailType")
                        .WithMany()
                        .HasForeignKey("EmailTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("EmailType");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.EmailType", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("ManageContacts.Entity.Entities.User", "Modifier")
                        .WithMany()
                        .HasForeignKey("ModifierId");

                    b.Navigation("Creator");

                    b.Navigation("Modifier");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Group", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.User", "User")
                        .WithMany("Groups")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.PhoneNumber", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.Contact", "Contact")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManageContacts.Entity.Entities.PhoneType", "PhoneType")
                        .WithMany()
                        .HasForeignKey("PhoneTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("PhoneType");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.PhoneType", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("ManageContacts.Entity.Entities.User", "Modifier")
                        .WithMany()
                        .HasForeignKey("ModifierId");

                    b.Navigation("Creator");

                    b.Navigation("Modifier");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Relative", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.Contact", "Contact")
                        .WithMany("Relatives")
                        .HasForeignKey("ContactId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManageContacts.Entity.Entities.RelativeType", "RelativeType")
                        .WithMany()
                        .HasForeignKey("RelativeTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("RelativeType");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.RelativeType", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("ManageContacts.Entity.Entities.User", "Modifier")
                        .WithMany()
                        .HasForeignKey("ModifierId");

                    b.Navigation("Creator");

                    b.Navigation("Modifier");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Role", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("ManageContacts.Entity.Entities.User", "Modifier")
                        .WithMany()
                        .HasForeignKey("ModifierId");

                    b.Navigation("Creator");

                    b.Navigation("Modifier");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.User", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("ManageContacts.Entity.Entities.User", "Modifier")
                        .WithMany()
                        .HasForeignKey("ModifierId");

                    b.Navigation("Creator");

                    b.Navigation("Modifier");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.UserRole", b =>
                {
                    b.HasOne("ManageContacts.Entity.Entities.User", "Creator")
                        .WithMany()
                        .HasForeignKey("CreatorId");

                    b.HasOne("ManageContacts.Entity.Entities.Role", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManageContacts.Entity.Entities.User", "User")
                        .WithMany("UserRoles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Creator");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Contact", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Company")
                        .IsRequired();

                    b.Navigation("EmailAddresses");

                    b.Navigation("PhoneNumbers");

                    b.Navigation("Relatives");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Group", b =>
                {
                    b.Navigation("Contacts");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("ManageContacts.Entity.Entities.User", b =>
                {
                    b.Navigation("Contacts");

                    b.Navigation("Groups");

                    b.Navigation("UserRoles");
                });
#pragma warning restore 612, 618
        }
    }
}
