using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using OrbCare.Models.Models;

namespace OrbCare.Models
{
    public partial class PariscribeContext : DbContext
    {
        public PariscribeContext(DbContextOptions<PariscribeContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AbtechNote> AbtechNote { get; set; }
        public virtual DbSet<Address> Address { get; set; }
        public virtual DbSet<Allergy> Allergy { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<AppointmentBagHystory> AppointmentBagHystory { get; set; }
        public virtual DbSet<AppointmentLastHl7Type> AppointmentLastHl7Type { get; set; }
        public virtual DbSet<AppointmentLock> AppointmentLock { get; set; }
        public virtual DbSet<AppointmentNote> AppointmentNote { get; set; }
        public virtual DbSet<AppointmentProcedure> AppointmentProcedure { get; set; }
        public virtual DbSet<AppointmentRecurrentPattern> AppointmentRecurrentPattern { get; set; }
        public virtual DbSet<AppointmentState> AppointmentState { get; set; }
        public virtual DbSet<AppointmentStatus> AppointmentStatus { get; set; }
        public virtual DbSet<AppointmentTemplate> AppointmentTemplate { get; set; }
        public virtual DbSet<AppointmentTemplateItem> AppointmentTemplateItem { get; set; }
        public virtual DbSet<AppointmentType> AppointmentType { get; set; }
        public virtual DbSet<ApprovedTransId> ApprovedTransId { get; set; }
        public virtual DbSet<Aprsob2011> Aprsob2011 { get; set; }
        public virtual DbSet<AttachmentType> AttachmentType { get; set; }
        public virtual DbSet<Audit> Audit { get; set; }
        public virtual DbSet<Bagpull> Bagpull { get; set; }
        public virtual DbSet<BarcodeType> BarcodeType { get; set; }
        public virtual DbSet<BillingComments> BillingComments { get; set; }
        public virtual DbSet<BillingStatus> BillingStatus { get; set; }
        public virtual DbSet<Card> Card { get; set; }
        public virtual DbSet<CardHistory> CardHistory { get; set; }
        public virtual DbSet<CashBillingCode> CashBillingCode { get; set; }
        public virtual DbSet<ClaimDetail> ClaimDetail { get; set; }
        public virtual DbSet<ClaimDetailReconciliation> ClaimDetailReconciliation { get; set; }
        public virtual DbSet<ClaimFile> ClaimFile { get; set; }
        public virtual DbSet<ClinicalHistroy> ClinicalHistroy { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<DeleteReason> DeleteReason { get; set; }
        public virtual DbSet<DiagnosticImage> DiagnosticImage { get; set; }
        public virtual DbSet<DicomHeader> DicomHeader { get; set; }
        public virtual DbSet<DictationDevice> DictationDevice { get; set; }
        public virtual DbSet<DictationLog> DictationLog { get; set; }
        public virtual DbSet<DictationNote> DictationNote { get; set; }
        public virtual DbSet<Doctor> Doctor { get; set; }
        public virtual DbSet<DoctorAddress> DoctorAddress { get; set; }
        public virtual DbSet<DoctorHistory> DoctorHistory { get; set; }
        public virtual DbSet<DoctorSpeciality> DoctorSpeciality { get; set; }
        public virtual DbSet<DoublePaidItem> DoublePaidItem { get; set; }
        public virtual DbSet<EdtfileNameSeq> EdtfileNameSeq { get; set; }
        public virtual DbSet<EdtjobLog> EdtjobLog { get; set; }
        public virtual DbSet<Encounter> Encounter { get; set; }
        public virtual DbSet<EncounterAttachment> EncounterAttachment { get; set; }
        public virtual DbSet<EncounterDoctor> EncounterDoctor { get; set; }
        public virtual DbSet<EncounterIconsSettings> EncounterIconsSettings { get; set; }
        public virtual DbSet<EncounterQuestion> EncounterQuestion { get; set; }
        public virtual DbSet<EncounterType> EncounterType { get; set; }
        public virtual DbSet<ErrorDetail> ErrorDetail { get; set; }
        public virtual DbSet<ErrorFile> ErrorFile { get; set; }
        public virtual DbSet<ExamBodyPart> ExamBodyPart { get; set; }
        public virtual DbSet<ExistingPatientPid> ExistingPatientPid { get; set; }
        public virtual DbSet<ExtEncounter> ExtEncounter { get; set; }
        public virtual DbSet<ExtLocation> ExtLocation { get; set; }
        public virtual DbSet<ExtPatMrn> ExtPatMrn { get; set; }
        public virtual DbSet<ExtraEncounter> ExtraEncounter { get; set; }
        public virtual DbSet<ExtraPatient> ExtraPatient { get; set; }
        public virtual DbSet<Facility> Facility { get; set; }
        public virtual DbSet<FacilityNote> FacilityNote { get; set; }
        public virtual DbSet<FacilityOffTimeGroup> FacilityOffTimeGroup { get; set; }
        public virtual DbSet<FacilitySchedule> FacilitySchedule { get; set; }
        public virtual DbSet<FacilityScheduleGroup> FacilityScheduleGroup { get; set; }
        public virtual DbSet<FacilityStaff> FacilityStaff { get; set; }
        public virtual DbSet<File> File { get; set; }
        public virtual DbSet<FileStorage> FileStorage { get; set; }
        public virtual DbSet<FormItemBak> FormItemBak { get; set; }
        public virtual DbSet<GroupEdtaccount> GroupEdtaccount { get; set; }
        public virtual DbSet<ImageViewers> ImageViewers { get; set; }
        public virtual DbSet<InventoryApplied> InventoryApplied { get; set; }
        public virtual DbSet<InventoryDistributed> InventoryDistributed { get; set; }
        public virtual DbSet<InventoryItem> InventoryItem { get; set; }
        public virtual DbSet<InventoryLocation> InventoryLocation { get; set; }
        public virtual DbSet<InventoryPurchase> InventoryPurchase { get; set; }
        public virtual DbSet<InventoryType> InventoryType { get; set; }
        public virtual DbSet<IssaScanDoc> IssaScanDoc { get; set; }
        public virtual DbSet<LabelSize> LabelSize { get; set; }
        public virtual DbSet<LiveAccountMapping> LiveAccountMapping { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Locationgroup> Locationgroup { get; set; }
        public virtual DbSet<LocationImageViewers> LocationImageViewers { get; set; }
        public virtual DbSet<LocationNextId> LocationNextId { get; set; }
        public virtual DbSet<LocationStaff> LocationStaff { get; set; }
        public virtual DbSet<MailMessage> MailMessage { get; set; }
        public virtual DbSet<MailMessageDeleted> MailMessageDeleted { get; set; }
        public virtual DbSet<MaritalStatus> MaritalStatus { get; set; }
        public virtual DbSet<MergedEncounter> MergedEncounter { get; set; }
        public virtual DbSet<MergeDoctor> MergeDoctor { get; set; }
        public virtual DbSet<MergedPatientExtMrn> MergedPatientExtMrn { get; set; }
        public virtual DbSet<MergedPrevisit> MergedPrevisit { get; set; }
        public virtual DbSet<MergeOperation> MergeOperation { get; set; }
        public virtual DbSet<Messages> Messages { get; set; }
        public virtual DbSet<Mhlcoffice> Mhlcoffice { get; set; }
        public virtual DbSet<MissingAccNo> MissingAccNo { get; set; }
        public virtual DbSet<Mrnbak> Mrnbak { get; set; }
        public virtual DbSet<NextBagNo> NextBagNo { get; set; }
        public virtual DbSet<OffTime> OffTime { get; set; }
        public virtual DbSet<OffTimeReason> OffTimeReason { get; set; }
        public virtual DbSet<OhipAppointmentCode> OhipAppointmentCode { get; set; }
        public virtual DbSet<OhipClaim> OhipClaim { get; set; }
        public virtual DbSet<OhipClaimFile> OhipClaimFile { get; set; }
        public virtual DbSet<OhipClaimFileClaim> OhipClaimFileClaim { get; set; }
        public virtual DbSet<OhipClaimFileContent> OhipClaimFileContent { get; set; }
        public virtual DbSet<OhipClaimJob> OhipClaimJob { get; set; }
        public virtual DbSet<OhipClaimStatus> OhipClaimStatus { get; set; }
        public virtual DbSet<OhipCodeTemplate> OhipCodeTemplate { get; set; }
        public virtual DbSet<OhipCodeTemplateItem> OhipCodeTemplateItem { get; set; }
        public virtual DbSet<OhipCutOffDate> OhipCutOffDate { get; set; }
        public virtual DbSet<OhipEdtAccount> OhipEdtAccount { get; set; }
        public virtual DbSet<OhipEdtClaimError> OhipEdtClaimError { get; set; }
        public virtual DbSet<OhipEdtErrorCode> OhipEdtErrorCode { get; set; }
        public virtual DbSet<OhipEdtRemittanceAdviceReport> OhipEdtRemittanceAdviceReport { get; set; }
        public virtual DbSet<OhipEdtReport> OhipEdtReport { get; set; }
        public virtual DbSet<OhipEdtSchedule> OhipEdtSchedule { get; set; }
        public virtual DbSet<OhipEdtSessionError> OhipEdtSessionError { get; set; }
        public virtual DbSet<OhipEdtSessionHistory> OhipEdtSessionHistory { get; set; }
        public virtual DbSet<OhipEdtSessionResult> OhipEdtSessionResult { get; set; }
        public virtual DbSet<OhipForm> OhipForm { get; set; }
        public virtual DbSet<OhipFormItem> OhipFormItem { get; set; }
        public virtual DbSet<OhipItemControl> OhipItemControl { get; set; }
        public virtual DbSet<OhipPrice> OhipPrice { get; set; }
        public virtual DbSet<OhipServiceCode> OhipServiceCode { get; set; }
        public virtual DbSet<OhipTechBilling> OhipTechBilling { get; set; }
        public virtual DbSet<OperationHours> OperationHours { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientAllergy> PatientAllergy { get; set; }
        public virtual DbSet<PatientBrooklin> PatientBrooklin { get; set; }
        public virtual DbSet<PatientChartNo> PatientChartNo { get; set; }
        public virtual DbSet<PatientDupNoHin> PatientDupNoHin { get; set; }
        public virtual DbSet<PatientExtMrn> PatientExtMrn { get; set; }
        public virtual DbSet<PatientHistory> PatientHistory { get; set; }
        public virtual DbSet<PatientMessage> PatientMessage { get; set; }
        public virtual DbSet<PatientPayor> PatientPayor { get; set; }
        public virtual DbSet<Payor> Payor { get; set; }
        public virtual DbSet<PdfreportQueue> PdfreportQueue { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonRole> PersonRole { get; set; }
        public virtual DbSet<PreviousVisit> PreviousVisit { get; set; }
        public virtual DbSet<Provider> Provider { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<RaclaimHeader> RaclaimHeader { get; set; }
        public virtual DbSet<RaclaimItem> RaclaimItem { get; set; }
        public virtual DbSet<RadColumnPrefernece> RadColumnPrefernece { get; set; }
        public virtual DbSet<Radetail> Radetail { get; set; }
        public virtual DbSet<RadiType> RadiType { get; set; }
        public virtual DbSet<RadPrefernece> RadPrefernece { get; set; }
        public virtual DbSet<RadserviceSite> RadserviceSite { get; set; }
        public virtual DbSet<Rafile> Rafile { get; set; }
        public virtual DbSet<Raheader> Raheader { get; set; }
        public virtual DbSet<Raitem> Raitem { get; set; }
        public virtual DbSet<Ramessage> Ramessage { get; set; }
        public virtual DbSet<RebilledThirdPartyBilling> RebilledThirdPartyBilling { get; set; }
        public virtual DbSet<RebilledThirdPartyItem> RebilledThirdPartyItem { get; set; }
        public virtual DbSet<RecurrenceUnit> RecurrenceUnit { get; set; }
        public virtual DbSet<RefDoc> RefDoc { get; set; }
        public virtual DbSet<RefDocHistory> RefDocHistory { get; set; }
        public virtual DbSet<ReferalReportType> ReferalReportType { get; set; }
        public virtual DbSet<ReferralDoctorGroupWeb> ReferralDoctorGroupWeb { get; set; }
        public virtual DbSet<ReferralGroup> ReferralGroup { get; set; }
        public virtual DbSet<ReferralPortalGroup> ReferralPortalGroup { get; set; }
        public virtual DbSet<ReferralRequest> ReferralRequest { get; set; }
        public virtual DbSet<ReferralRequestServiceItem> ReferralRequestServiceItem { get; set; }
        public virtual DbSet<Register> Register { get; set; }
        public virtual DbSet<RegisterSpeciality> RegisterSpeciality { get; set; }
        public virtual DbSet<RejectNote> RejectNote { get; set; }
        public virtual DbSet<RepeatedWorklistItems> RepeatedWorklistItems { get; set; }
        public virtual DbSet<ReportDeliveryLog> ReportDeliveryLog { get; set; }
        public virtual DbSet<ReportDeliveryMethod> ReportDeliveryMethod { get; set; }
        public virtual DbSet<ReportDeliveryPriority> ReportDeliveryPriority { get; set; }
        public virtual DbSet<ReportDeliveryQueue> ReportDeliveryQueue { get; set; }
        public virtual DbSet<ReportDeliveryQueueJobStatus> ReportDeliveryQueueJobStatus { get; set; }
        public virtual DbSet<ReportDeliverySettings> ReportDeliverySettings { get; set; }
        public virtual DbSet<ReportDeliveryStatus> ReportDeliveryStatus { get; set; }
        public virtual DbSet<ReportingServicesSettings> ReportingServicesSettings { get; set; }
        public virtual DbSet<ReportLocationGroup> ReportLocationGroup { get; set; }
        public virtual DbSet<ReportTemplate> ReportTemplate { get; set; }
        public virtual DbSet<ReportTemplateBody> ReportTemplateBody { get; set; }
        public virtual DbSet<ReportTemplateKeyword> ReportTemplateKeyword { get; set; }
        public virtual DbSet<ReportTemplateMapping> ReportTemplateMapping { get; set; }
        public virtual DbSet<ReportViewStatus> ReportViewStatus { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Schedule> Schedule { get; set; }
        public virtual DbSet<ScheduleTemplate> ScheduleTemplate { get; set; }
        public virtual DbSet<ScheduleTemplateRecord> ScheduleTemplateRecord { get; set; }
        public virtual DbSet<ScheduleWork> ScheduleWork { get; set; }
        public virtual DbSet<SecurityQuestion> SecurityQuestion { get; set; }
        public virtual DbSet<SitePreference> SitePreference { get; set; }
        public virtual DbSet<Speciality> Speciality { get; set; }
        public virtual DbSet<SysKeys> SysKeys { get; set; }
        public virtual DbSet<TablesChangedByMerge> TablesChangedByMerge { get; set; }
        public virtual DbSet<TechNote> TechNote { get; set; }
        public virtual DbSet<TechNoteItem> TechNoteItem { get; set; }
        public virtual DbSet<TestType> TestType { get; set; }
        public virtual DbSet<TestTypeReportDoctor> TestTypeReportDoctor { get; set; }
        public virtual DbSet<ThirdPartyBilling> ThirdPartyBilling { get; set; }
        public virtual DbSet<ThirdPartyBillingItem> ThirdPartyBillingItem { get; set; }
        public virtual DbSet<ThirdPartyInvoice> ThirdPartyInvoice { get; set; }
        public virtual DbSet<ThirdPartyPayment> ThirdPartyPayment { get; set; }
        public virtual DbSet<ThirdPartyPaymentItem> ThirdPartyPaymentItem { get; set; }
        public virtual DbSet<ThirdPartyPaymentMethod> ThirdPartyPaymentMethod { get; set; }
        public virtual DbSet<ThirdPartyPayor> ThirdPartyPayor { get; set; }
        public virtual DbSet<TmpTableDrclaim> TmpTableDrclaim { get; set; }
        public virtual DbSet<TmpTableDrclaim1> TmpTableDrclaim1 { get; set; }
        public virtual DbSet<TmpTableDrpatient> TmpTableDrpatient { get; set; }
        public virtual DbSet<TmpTableEncId> TmpTableEncId { get; set; }
        public virtual DbSet<TmpTablerefDrTable> TmpTablerefDrTable { get; set; }
        public virtual DbSet<TmpTablereferralReport> TmpTablereferralReport { get; set; }
        public virtual DbSet<TranApprovedId> TranApprovedId { get; set; }
        public virtual DbSet<Transcription> Transcription { get; set; }
        public virtual DbSet<TranscriptionAddendum> TranscriptionAddendum { get; set; }
        public virtual DbSet<TranscriptionBody> TranscriptionBody { get; set; }
        public virtual DbSet<TranscriptionError> TranscriptionError { get; set; }
        public virtual DbSet<TranscriptionHistory> TranscriptionHistory { get; set; }
        public virtual DbSet<TranscriptionStatus> TranscriptionStatus { get; set; }
        public virtual DbSet<TranscriptionUpdateLog> TranscriptionUpdateLog { get; set; }
        public virtual DbSet<TravelTime> TravelTime { get; set; }
        public virtual DbSet<TypistLog> TypistLog { get; set; }
        public virtual DbSet<UniqueNumber> UniqueNumber { get; set; }
        public virtual DbSet<UpdatedTranscriptionBody> UpdatedTranscriptionBody { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserCurAccNo> UserCurAccNo { get; set; }
        public virtual DbSet<UserImageViewers> UserImageViewers { get; set; }
        public virtual DbSet<UserPrefernece> UserPrefernece { get; set; }
        public virtual DbSet<UserSession> UserSession { get; set; }
        public virtual DbSet<UserSettings> UserSettings { get; set; }
        public virtual DbSet<VoiceRecord> VoiceRecord { get; set; }
        public virtual DbSet<VReadingDoctor> VReadingDoctor { get; set; }
        public virtual DbSet<WaitingListGroup> WaitingListGroup { get; set; }
        public virtual DbSet<WaitingListItem> WaitingListItem { get; set; }
        public virtual DbSet<WorklistFilter> WorklistFilter { get; set; }
        public virtual DbSet<WorksheetMapping> WorksheetMapping { get; set; }

        // Unable to generate entity type for table 'dbo.RAAccountTrans'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.ExtPatient'. Please see the warning messages.
        // Unable to generate entity type for table 'dbo.BillingClaimSummary'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=MALBALLAH-PC\MSSQLSERVER2014;Database=Pariscribe;User ID=sa;Password=P@ssw0rd");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AbtechNote>(entity =>
            {
                entity.ToTable("ABTechNote");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.BodyPart)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.BodyPartId)
                    .HasColumnName("BodyPartID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FilmsCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Fltime)
                    .HasColumnName("FLTime")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ImagesCount)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Lmp)
                    .HasColumnName("LMP")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RepeatComments)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RepeatImages)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SecondaryTechId).HasColumnName("SecondaryTechID");
            });

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasIndex(e => e.Fax)
                    .HasName("Address_fax_idx");

                entity.HasIndex(e => e.Pid)
                    .HasName("Address_pid_idx");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressLine)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.PostCode).HasMaxLength(10);

                entity.Property(e => e.ProvinceId)
                    .HasColumnName("ProvinceID")
                    .HasDefaultValueSql("((9))");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Address_Country");

                entity.HasOne(d => d.Province)
                    .WithMany(p => p.Address)
                    .HasForeignKey(d => d.ProvinceId)
                    .HasConstraintName("FK_Address_Province");
            });

            modelBuilder.Entity<Allergy>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Appointment>(entity =>
            {
                entity.HasIndex(e => e.AccessionNumber)
                    .HasName("Appointment_IDX_AccNO");

                entity.HasIndex(e => new { e.Id, e.TranscriptionId })
                    .HasName("Appointment_IDX_tranID");

                entity.HasIndex(e => new { e.AccessionNumber, e.TranscriptionId, e.EncounterId })
                    .HasName("Appointmnet_IDX_3");

                entity.HasIndex(e => new { e.EncounterId, e.StartTime, e.EndTime, e.FacilityId })
                    .HasName("Appointment_IDX_2");

                entity.HasIndex(e => new { e.Id, e.AccessionNumber, e.PacStatusId, e.StatusId, e.PacUpdateTime })
                    .HasName("Appointment_pacTime_stsID");

                entity.HasIndex(e => new { e.Id, e.EncounterId, e.FacilityId, e.IsActive, e.RadiologyDoctorId })
                    .HasName("Appointment_Idx_10");

                entity.HasIndex(e => new { e.EncounterId, e.FacilityId, e.StatusId, e.AccessionNumber, e.RadiologyDoctorId, e.IsActive, e.PacUpdateTime })
                    .HasName("Appointment_IDX_PacUpdateTime");

                entity.HasIndex(e => new { e.Id, e.EncounterId, e.FacilityId, e.StartTime, e.StatusId, e.AccessionNumber, e.IsActive })
                    .HasName("Appointment_IDX_1");

                entity.HasIndex(e => new { e.Id, e.EncounterId, e.StartTime, e.StatusId, e.AccessionNumber, e.TranscriptionId, e.IsActive })
                    .HasName("Appointment_IDX_isActive");

                entity.HasIndex(e => new { e.Id, e.EncounterId, e.FacilityId, e.AccessionNumber, e.TranscriptionId, e.IsActive, e.StatusId, e.RadiologyDoctorId })
                    .HasName("Appointment_Idx_isactive_stsID_radDocID");

                entity.HasIndex(e => new { e.Id, e.EncounterId, e.FacilityId, e.TranscriptionId, e.RadLockUid, e.IsActive, e.StatusId, e.AccessionNumber, e.RadiologyDoctorId })
                    .HasName("Appointment_idx_11");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessionNumber)
                    .IsRequired()
                    .HasMaxLength(12)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AppHistId).HasColumnName("appHistID");

                entity.Property(e => e.AppointmentTypeId)
                    .HasColumnName("AppointmentTypeID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ConfirmedTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.ConfirmedUserId).HasColumnName("ConfirmedUserID");

                entity.Property(e => e.DeleteReason).HasMaxLength(255);

                entity.Property(e => e.DeleteReasonId).HasColumnName("DeleteReasonID");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.EncounterTypeId).HasColumnName("EncounterTypeID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.ImageViewerId).HasColumnName("ImageViewerID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.PacStatusId).HasColumnName("PacStatusID");

                entity.Property(e => e.PacUpdateTime).HasColumnType("datetime");

                entity.Property(e => e.PreRadiologyDoctorId).HasColumnName("PreRadiologyDoctorID");

                entity.Property(e => e.RadLockUid).HasColumnName("RadLockUID");

                entity.Property(e => e.RadiologyDoctorId).HasColumnName("RadiologyDoctorID");

                entity.Property(e => e.RecurrentPatternId).HasColumnName("RecurrentPatternID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TechnicianStaffId)
                    .HasColumnName("TechnicianStaffID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TranLockTime).HasColumnType("datetime");

                entity.Property(e => e.TranLockUid).HasColumnName("TranLockUID");

                entity.Property(e => e.TranscribeUid).HasColumnName("TranscribeUID");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");

                entity.HasOne(d => d.AppointmentType)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.AppointmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_AppointmentType");

                entity.HasOne(d => d.ConfirmedUser)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.ConfirmedUserId)
                    .HasConstraintName("FK_Appointment_User");

                entity.HasOne(d => d.DeleteReasonNavigation)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.DeleteReasonId)
                    .HasConstraintName("FK_Appointment_DeleteReason");

                entity.HasOne(d => d.Encounter)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.EncounterId)
                    .HasConstraintName("FK_Appointment_Encounter");

                entity.HasOne(d => d.EncounterType)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.EncounterTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_EncounterType");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_Facility");

                entity.HasOne(d => d.ImageViewer)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.ImageViewerId)
                    .HasConstraintName("FK_Appointment_ImageViewers");

                entity.HasOne(d => d.RadiologyDoctor)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.RadiologyDoctorId)
                    .HasConstraintName("FK_Appointment_Doctor");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Appointment_AppointmentStatus");

                entity.HasOne(d => d.Transcription)
                    .WithMany(p => p.Appointment)
                    .HasForeignKey(d => d.TranscriptionId)
                    .HasConstraintName("FK_Appointment_Transcription");
            });

            modelBuilder.Entity<AppointmentBagHystory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.IssuerUserId).HasColumnName("IssuerUserID");

                entity.Property(e => e.PulledDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PulledToDoctorId).HasColumnName("PulledToDoctorID");

                entity.Property(e => e.ReturnUserId).HasColumnName("ReturnUserID");

                entity.Property(e => e.ReturnedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentBagHystory)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppointmentBagHystory_Appointment");

                entity.HasOne(d => d.IssuerUser)
                    .WithMany(p => p.AppointmentBagHystoryIssuerUser)
                    .HasForeignKey(d => d.IssuerUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppointmentBagHystory_User");

                entity.HasOne(d => d.PulledToDoctor)
                    .WithMany(p => p.AppointmentBagHystory)
                    .HasForeignKey(d => d.PulledToDoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppointmentBagHystory_Doctor");

                entity.HasOne(d => d.ReturnUser)
                    .WithMany(p => p.AppointmentBagHystoryReturnUser)
                    .HasForeignKey(d => d.ReturnUserId)
                    .HasConstraintName("FK_AppointmentBagHystory_User1");
            });

            modelBuilder.Entity<AppointmentLastHl7Type>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.MessageType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");
            });

            modelBuilder.Entity<AppointmentLock>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RadLockTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RadLockUid).HasColumnName("RadLockUID");
            });

            modelBuilder.Entity<AppointmentNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Note)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.AppointmentNote)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppointmentNote_Appointment");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.AppointmentNote)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppointmentNote_Color");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.AppointmentNote)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppointmentNote_User");
            });

            modelBuilder.Entity<AppointmentProcedure>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentTemplateId).HasColumnName("AppointmentTemplateID");

                entity.Property(e => e.EncounterTemplateId).HasColumnName("EncounterTemplateID");

                entity.HasOne(d => d.AppointmentTemplate)
                    .WithMany(p => p.AppointmentProcedure)
                    .HasForeignKey(d => d.AppointmentTemplateId)
                    .HasConstraintName("FK_AppointmentProcedure_AppointmentTemplate");

                entity.HasOne(d => d.EncounterTemplate)
                    .WithMany(p => p.AppointmentProcedure)
                    .HasForeignKey(d => d.EncounterTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppointmentProcedure_EncounterType");
            });

            modelBuilder.Entity<AppointmentRecurrentPattern>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.VisitEnd).HasColumnType("datetime");

                entity.Property(e => e.VisitStart).HasColumnType("datetime");
            });

            modelBuilder.Entity<AppointmentState>(entity =>
            {
                entity.HasKey(e => e.AppointmentId);

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("AppointmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.HcvresponseCode)
                    .HasColumnName("HCVResponseCode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HelthCardStatusState).HasDefaultValueSql("((0))");

                entity.Property(e => e.LabState).HasDefaultValueSql("((0))");

                entity.Property(e => e.NoteState).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<AppointmentStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<AppointmentTemplate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.AppointmentTemplate)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AppointmentTemplate_Location");
            });

            modelBuilder.Entity<AppointmentTemplateItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentTemplateId).HasColumnName("AppointmentTemplateID");

                entity.Property(e => e.Duration).HasDefaultValueSql("((10))");

                entity.Property(e => e.EncounterTypeId).HasColumnName("EncounterTypeID");
            });

            modelBuilder.Entity<AppointmentType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ApprovedTransId>(entity =>
            {
                entity.ToTable("approvedTransID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Aprsob2011>(entity =>
            {
                entity.HasKey(e => e.CodeBase);

                entity.ToTable("APRSOB2011");

                entity.Property(e => e.CodeBase)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.A).HasColumnType("money");

                entity.Property(e => e.AnFee).HasColumnType("money");

                entity.Property(e => e.B).HasColumnType("money");

                entity.Property(e => e.C).HasColumnType("money");

                entity.Property(e => e.D).HasColumnType("money");

                entity.Property(e => e.EffDate)
                    .HasColumnName("effDate")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.TermDate)
                    .HasColumnName("termDate")
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AttachmentType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AttachmentTypeName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Audit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionDetail)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.AuditDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.LongDescription)
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.ReferenceId1).HasColumnName("referenceID1");

                entity.Property(e => e.ReferenceId2).HasColumnName("referenceID2");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Bagpull>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccessionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BagNo)
                    .HasColumnName("BagNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.PullComment)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PullDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ReturnComment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReturnDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<BarcodeType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<BillingComments>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");
            });

            modelBuilder.Entity<BillingStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Card>(entity =>
            {
                entity.HasIndex(e => e.Pid)
                    .HasName("Card_pid_idx");

                entity.HasIndex(e => new { e.Id, e.Hin })
                    .HasName("Card_IDX_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateCreated)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.Hin)
                    .IsRequired()
                    .HasColumnName("HIN")
                    .HasMaxLength(13)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.HinprovinceId)
                    .HasColumnName("HINProvinceID")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.VersionCode).HasMaxLength(2);
            });

            modelBuilder.Entity<CardHistory>(entity =>
            {
                entity.HasKey(e => new { e.PersonId, e.CardId });

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.CardHistory)
                    .HasForeignKey(d => d.CardId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CardHistory_Card");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.CardHistory)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CardHistory_Person");
            });

            modelBuilder.Entity<CashBillingCode>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.A).HasColumnType("money");

                entity.Property(e => e.B).HasColumnType("money");

                entity.Property(e => e.C).HasColumnType("money");

                entity.Property(e => e.Codebase)
                    .HasColumnName("CODEBASE")
                    .HasMaxLength(255);

                entity.Property(e => e.D).HasColumnType("money");
            });

            modelBuilder.Entity<ClaimDetail>(entity =>
            {
                entity.HasIndex(e => e.BaseId)
                    .HasName("ClaimDetail_idx_baseID");

                entity.HasIndex(e => new { e.SubmittedFee, e.FileId, e.ResubmitCount })
                    .HasName("ClaimDetail_IDX_FileIDCount");

                entity.HasIndex(e => new { e.EncounterId, e.ServiceCode, e.NumberOfService, e.Id })
                    .HasName("ClaimDetail_IDX_4");

                entity.HasIndex(e => new { e.Id, e.EncounterId, e.ServiceCode, e.NumberOfService, e.ResubmitCount })
                    .HasName("ClaimDetail_IDX_2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BaseId).HasColumnName("BaseID");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.Ihfcode)
                    .HasColumnName("IHFCode")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.IsPaid).HasColumnName("isPaid");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PaidAmount).HasColumnType("money");

                entity.Property(e => e.PaidStatus)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RaItemId).HasColumnName("RaItemID");

                entity.Property(e => e.RefProviderId)
                    .HasColumnName("RefProviderID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SubmittedFee).HasColumnType("money");
            });

            modelBuilder.Entity<ClaimDetailReconciliation>(entity =>
            {
                entity.HasKey(e => e.ClaimId);

                entity.Property(e => e.ClaimId)
                    .HasColumnName("ClaimID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.DrId).HasColumnName("DrID");

                entity.Property(e => e.DrName)
                    .IsRequired()
                    .HasMaxLength(102);

                entity.Property(e => e.Explancode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode).HasColumnType("char(4)");

                entity.Property(e => e.Hin)
                    .HasColumnName("HIN")
                    .HasMaxLength(13);

                entity.Property(e => e.LocationCode)
                    .HasColumnName("locationCode")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.PaidFee)
                    .HasColumnName("paidFee")
                    .HasColumnType("money");

                entity.Property(e => e.PaidStatus)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .IsRequired()
                    .HasMaxLength(152);

                entity.Property(e => e.ProcessDate)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.SubmittedFee).HasColumnType("money");
            });

            modelBuilder.Entity<ClaimFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Batchfile)
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.CreationDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.FileStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Uploading')");

                entity.Property(e => e.IsReject)
                    .HasColumnName("isReject")
                    .HasColumnType("char(1)");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Message)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessDate)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId)
                    .HasColumnName("ProviderID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RadDocId).HasColumnName("RadDocID");

                entity.Property(e => e.ResubmitAmount).HasColumnType("money");

                entity.Property(e => e.SeqNo).HasColumnName("SeqNO");

                entity.Property(e => e.TotalAmount).HasColumnType("money");
            });

            modelBuilder.Entity<ClinicalHistroy>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.History)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Argb).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UseForComment).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DeleteReason>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<DiagnosticImage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.DiagnosticImage)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiagnosticImage_Appointment");

                entity.HasOne(d => d.Header)
                    .WithMany(p => p.DiagnosticImage)
                    .HasForeignKey(d => d.HeaderId)
                    .HasConstraintName("FK_DiagnosticImage_DicomHeader");

                entity.HasOne(d => d.ImageFile)
                    .WithMany(p => p.DiagnosticImage)
                    .HasForeignKey(d => d.ImageFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DiagnosticImage_File");
            });

            modelBuilder.Entity<DicomHeader>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.FullHeader)
                    .IsRequired()
                    .HasColumnType("xml");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DictationDevice>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DictationLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.DictationTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");
            });

            modelBuilder.Entity<DictationNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.Note)
                    .HasMaxLength(450)
                    .IsUnicode(false);

                entity.Property(e => e.ReadTime).HasColumnType("datetime");

                entity.Property(e => e.ReadUserId).HasColumnName("ReadUserID");
            });

            modelBuilder.Entity<Doctor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Inactive)
                    .HasColumnName("inactive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MohofficeCode)
                    .HasColumnName("MOHOfficeCode")
                    .HasMaxLength(2);

                entity.Property(e => e.OtherAddressId).HasColumnName("OtherAddressID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.SignatureImageId).HasColumnName("SignatureImageID");

                entity.Property(e => e.SpecialityId).HasColumnName("SpecialityID");

                entity.HasOne(d => d.OtherAddress)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.OtherAddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctor_Address");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctor_Person");

                entity.HasOne(d => d.Provider)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.ProviderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctor_Provider");

                entity.HasOne(d => d.SignatureImage)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.SignatureImageId)
                    .HasConstraintName("FK_Doctor_SignatureFile");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.Doctor)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Doctor_DoctorSpeciality");
            });

            modelBuilder.Entity<DoctorAddress>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DoctorHistory>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.Property(e => e.Code)
                    .HasMaxLength(6)
                    .ValueGeneratedNever();

                entity.Property(e => e.Location).HasMaxLength(4);

                entity.Property(e => e.Name).HasMaxLength(30);

                entity.Property(e => e.OhipOffice)
                    .IsRequired()
                    .HasMaxLength(1);
            });

            modelBuilder.Entity<DoctorSpeciality>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<DoublePaidItem>(entity =>
            {
                entity.HasKey(e => e.EncounterId);

                entity.Property(e => e.EncounterId)
                    .HasColumnName("EncounterID")
                    .ValueGeneratedNever();

                entity.Property(e => e.FeePaid).HasColumnType("money");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EdtfileNameSeq>(entity =>
            {
                entity.ToTable("EDTFileNameSeq");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileNamePrefix)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EdtjobLog>(entity =>
            {
                entity.ToTable("EDTJobLog");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.LogTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Message)
                    .HasMaxLength(750)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Encounter>(entity =>
            {
                entity.HasIndex(e => e.VisitNumber)
                    .HasName("Encounter_IDX_visitNumber");

                entity.HasIndex(e => new { e.Id, e.VisitNumber })
                    .HasName("Encounter_Idx_Bag");

                entity.HasIndex(e => new { e.Id, e.PatientId, e.PayorId, e.Date })
                    .HasName("Encounter_IDX_10");

                entity.HasIndex(e => new { e.Id, e.PatientId, e.VisitNumber, e.Date })
                    .HasName("Encounter_IDX_Date");

                entity.HasIndex(e => new { e.Id, e.PatientId, e.VisitReason, e.Date })
                    .HasName("Encounter_IDX_1");

                entity.HasIndex(e => new { e.Id, e.ReceivedRequisition, e.VisitReason, e.IsUrgent, e.PatientId, e.Date })
                    .HasName("Encounter_Idx_PatID_Date");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Bookedtime)
                    .HasColumnName("bookedtime")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EncHistId).HasColumnName("encHistID");

                entity.Property(e => e.Note).HasMaxLength(255);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PayorId).HasColumnName("PayorID");

                entity.Property(e => e.ReferralRequestId).HasColumnName("ReferralRequestID");

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VisitReason)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.Encounter)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Encounter_Patient");

                entity.HasOne(d => d.Payor)
                    .WithMany(p => p.Encounter)
                    .HasForeignKey(d => d.PayorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Encounter_Payor");
            });

            modelBuilder.Entity<EncounterAttachment>(entity =>
            {
                entity.HasIndex(e => e.EncounterId)
                    .HasName("EncounterAttachment_Idx_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AttachedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AttachmentTypeId)
                    .HasColumnName("AttachmentTypeID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BodyPartId).HasColumnName("BodyPartID");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.IsChecked).HasColumnName("isChecked");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.EncounterAttachment)
                    .HasForeignKey(d => d.AttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EncounterAttachment_AttachmentType");

                entity.HasOne(d => d.Encounter)
                    .WithMany(p => p.EncounterAttachment)
                    .HasForeignKey(d => d.EncounterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EncounterAttachment_Encounter");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.EncounterAttachment)
                    .HasForeignKey(d => d.FileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EncounterAttachment_File");
            });

            modelBuilder.Entity<EncounterDoctor>(entity =>
            {
                entity.HasIndex(e => new { e.DoctorId, e.EncounterId })
                    .HasName("EncounterDoctor_IDX_2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.IsPrimary).HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.EncounterDoctor)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_EncounterDoctor_Doctor");

                entity.HasOne(d => d.Encounter)
                    .WithMany(p => p.EncounterDoctor)
                    .HasForeignKey(d => d.EncounterId)
                    .HasConstraintName("FK_EncounterDoctor_Encounter");
            });

            modelBuilder.Entity<EncounterIconsSettings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Attachments).HasColumnType("image");

                entity.Property(e => e.BagPull).HasColumnType("image");

                entity.Property(e => e.DeleteAppointment).HasColumnType("image");

                entity.Property(e => e.EditPatient).HasColumnType("image");

                entity.Property(e => e.EmergencyStatusNormal).HasColumnType("image");

                entity.Property(e => e.EmergencyStatusUrgent).HasColumnType("image");

                entity.Property(e => e.HelthCardStatusEmpty).HasColumnType("image");

                entity.Property(e => e.HelthCardStatusInvalid).HasColumnType("image");

                entity.Property(e => e.HelthCardStatusNotValidated).HasColumnType("image");

                entity.Property(e => e.HelthCardStatusValid).HasColumnType("image");

                entity.Property(e => e.Images).HasColumnType("image");

                entity.Property(e => e.MessageCenter).HasColumnType("image");

                entity.Property(e => e.NoteIconTemplate).HasColumnType("image");

                entity.Property(e => e.Ohipbilling)
                    .HasColumnName("OHIPBilling")
                    .HasColumnType("image");

                entity.Property(e => e.PatientStatusAbsent).HasColumnType("image");

                entity.Property(e => e.PatientStatusClosed).HasColumnType("image");

                entity.Property(e => e.PatientStatusFinished).HasColumnType("image");

                entity.Property(e => e.PatientStatusInProgress).HasColumnType("image");

                entity.Property(e => e.PatientStatusWaiting).HasColumnType("image");

                entity.Property(e => e.PreviousVisite).HasColumnType("image");

                entity.Property(e => e.PrintChart).HasColumnType("image");

                entity.Property(e => e.PrintLabel).HasColumnType("image");

                entity.Property(e => e.PrintReport).HasColumnType("image");

                entity.Property(e => e.RebookAppointment).HasColumnType("image");

                entity.Property(e => e.ReferringDoctor).HasColumnType("image");

                entity.Property(e => e.Report).HasColumnType("image");

                entity.Property(e => e.RequisitionStatusNo).HasColumnType("image");

                entity.Property(e => e.RequisitionStatusYes).HasColumnType("image");

                entity.Property(e => e.ThirdPartyBilling).HasColumnType("image");

                entity.Property(e => e.VoiceFiles).HasColumnType("image");
            });

            modelBuilder.Entity<EncounterQuestion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Answer).HasMaxLength(250);

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.QuestionId).HasColumnName("QuestionID");
            });

            modelBuilder.Entity<EncounterType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(2);

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TestTypeId).HasColumnName("TestTypeID");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.EncounterType)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_EnocunterType_Color");

                entity.HasOne(d => d.TestType)
                    .WithMany(p => p.EncounterType)
                    .HasForeignKey(d => d.TestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EnocunterType_TestType");
            });

            modelBuilder.Entity<ErrorDetail>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ErrorCode).HasMaxLength(20);

                entity.Property(e => e.ErrorFileId).HasColumnName("ErrorFileID");
            });

            modelBuilder.Entity<ErrorFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hcount)
                    .HasColumnName("HCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProcessDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tcount)
                    .HasColumnName("TCount")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ExamBodyPart>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PartName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExistingPatientPid>(entity =>
            {
                entity.HasKey(e => e.PatId);

                entity.ToTable("ExistingPatientPID");

                entity.Property(e => e.PatId)
                    .HasColumnName("patID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");
            });

            modelBuilder.Entity<ExtEncounter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Birthday)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.ExtLocationId)
                    .HasColumnName("ExtLocationID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hin)
                    .HasColumnName("HIN")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Payee)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentProgram)
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Province)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.RaitemId).HasColumnName("RAItemID");

                entity.Property(e => e.ReferalProviderId)
                    .HasColumnName("ReferalProviderID")
                    .HasColumnType("char(6)");

                entity.Property(e => e.Sex)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.VersionCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExtLocation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocPrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Name)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExtPatMrn>(entity =>
            {
                entity.ToTable("ExtPatMRN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocCode).HasColumnType("char(1)");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Mrn)
                    .HasColumnName("MRN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Pid).HasColumnName("PID");
            });

            modelBuilder.Entity<ExtraEncounter>(entity =>
            {
                entity.HasKey(e => e.EncId);

                entity.ToTable("extraEncounter");

                entity.Property(e => e.EncId)
                    .HasColumnName("encID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessionNumber)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.AddressLine)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Appid).HasColumnName("appid");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.AsproviderId)
                    .HasColumnName("ASProviderID")
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CodeTemplateId).HasColumnName("CodeTemplateID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.EncounterTypeId).HasColumnName("EncounterTypeID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Hin)
                    .IsRequired()
                    .HasColumnName("HIN")
                    .HasMaxLength(11);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.Mrn)
                    .IsRequired()
                    .HasColumnName("MRN")
                    .HasMaxLength(50);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PayorId).HasColumnName("PayorID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Pid).HasColumnName("PID");

                entity.Property(e => e.PostCode).HasMaxLength(10);

                entity.Property(e => e.RadiologyDoctorId).HasColumnName("RadiologyDoctorID");

                entity.Property(e => e.RefAddress)
                    .HasColumnName("refAddress")
                    .HasMaxLength(250);

                entity.Property(e => e.RefFax)
                    .HasColumnName("refFax")
                    .HasMaxLength(50);

                entity.Property(e => e.RefFname)
                    .HasColumnName("refFname")
                    .HasMaxLength(50);

                entity.Property(e => e.RefLname)
                    .HasColumnName("refLname")
                    .HasMaxLength(50);

                entity.Property(e => e.RefPhone)
                    .HasColumnName("refPhone")
                    .HasMaxLength(50);

                entity.Property(e => e.Salutation)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.VersionCode).HasMaxLength(2);

                entity.Property(e => e.VisitReason)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<ExtraPatient>(entity =>
            {
                entity.HasKey(e => e.Pid);

                entity.Property(e => e.Pid)
                    .HasColumnName("PID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressLine)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.BusinessPhone).HasMaxLength(50);

                entity.Property(e => e.CardCreateDate).HasColumnType("datetime");

                entity.Property(e => e.CardProvCode)
                    .HasColumnName("cardProvCode")
                    .HasMaxLength(2);

                entity.Property(e => e.CardProvId).HasColumnName("cardProvID");

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.FamilyDoctor)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasColumnType("nchar(1)");

                entity.Property(e => e.Hin)
                    .IsRequired()
                    .HasColumnName("HIN")
                    .HasMaxLength(11);

                entity.Property(e => e.IssueDate).HasColumnType("datetime");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Mrn)
                    .IsRequired()
                    .HasColumnName("MRN")
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(50);

                entity.Property(e => e.PatProvCode).HasMaxLength(2);

                entity.Property(e => e.PatProvId).HasColumnName("PatProvID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostCode).HasMaxLength(10);

                entity.Property(e => e.Provider).HasMaxLength(50);

                entity.Property(e => e.Salutation)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.VersionCode).HasMaxLength(2);
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Aetitle)
                    .HasColumnName("AETitle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BarcodeTypeId).HasColumnName("BarcodeTypeID");

                entity.Property(e => e.BaseTypeId).HasColumnName("BaseTypeID");

                entity.Property(e => e.BillingDoctorId)
                    .HasColumnName("BillingDoctorID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.DefaultTimeSpan).HasDefaultValueSql("((10))");

                entity.Property(e => e.FunctionName).HasMaxLength(250);

                entity.Property(e => e.Ihf)
                    .HasColumnName("IHF")
                    .HasMaxLength(4);

                entity.Property(e => e.Ihfa)
                    .HasColumnName("IHFA")
                    .HasMaxLength(4);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.MasterNumber).HasMaxLength(4);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShortName)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ShowPrevEncounters).HasDefaultValueSql("((4))");

                entity.Property(e => e.WorklistName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.BarcodeType)
                    .WithMany(p => p.Facility)
                    .HasForeignKey(d => d.BarcodeTypeId)
                    .HasConstraintName("FK_Facility_BarcodeType");

                entity.HasOne(d => d.BaseType)
                    .WithMany(p => p.Facility)
                    .HasForeignKey(d => d.BaseTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facility_TestType");

                entity.HasOne(d => d.BillingDoctor)
                    .WithMany(p => p.Facility)
                    .HasForeignKey(d => d.BillingDoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facility_User");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Facility)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Facility_Location");
            });

            modelBuilder.Entity<FacilityNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FacilityOffTimeGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.IsByWeekday).HasColumnName("isByWeekday");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.ReasonNote)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<FacilitySchedule>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.RecurrenceUnitId).HasColumnName("RecurrenceUnitID");

                entity.Property(e => e.ScheduleTemplateId).HasColumnName("ScheduleTemplateID");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.RecurrenceUnit)
                    .WithMany(p => p.FacilitySchedule)
                    .HasForeignKey(d => d.RecurrenceUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FacilitySchedule_RecurrenceUnit");

                entity.HasOne(d => d.ScheduleTemplate)
                    .WithMany(p => p.FacilitySchedule)
                    .HasForeignKey(d => d.ScheduleTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FacilitySchedule_ScheduleTemplate");
            });

            modelBuilder.Entity<FacilityScheduleGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsByWeekday).HasColumnName("isByWeekday");

                entity.Property(e => e.ScheduleTemplateId).HasColumnName("ScheduleTemplateID");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<FacilityStaff>(entity =>
            {
                entity.HasKey(e => new { e.LocationStaffId, e.FacilityId });

                entity.Property(e => e.LocationStaffId).HasColumnName("LocationStaffID");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.StaffName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.FacilityStaff)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FacilityStaff_Facility");

                entity.HasOne(d => d.LocationStaff)
                    .WithMany(p => p.FacilityStaff)
                    .HasForeignKey(d => d.LocationStaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FacilityStaff_LocationStaff");
            });

            modelBuilder.Entity<File>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.OriginalFileName).HasMaxLength(500);

                entity.Property(e => e.StorageId).HasColumnName("StorageID");

                entity.HasOne(d => d.Storage)
                    .WithMany(p => p.File)
                    .HasForeignKey(d => d.StorageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_File_FileStorage");
            });

            modelBuilder.Entity<FileStorage>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<FormItemBak>(entity =>
            {
                entity.ToTable("formItem_BAK");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.OhipFormId).HasColumnName("OhipFormID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");
            });

            modelBuilder.Entity<GroupEdtaccount>(entity =>
            {
                entity.ToTable("groupEDTAccount");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mohaccount)
                    .HasColumnName("MOHAccount")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ImageViewers>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultSettings).HasMaxLength(4000);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserSettings).HasMaxLength(4000);
            });

            modelBuilder.Entity<InventoryApplied>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");
            });

            modelBuilder.Entity<InventoryDistributed>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EncounterTypeId).HasColumnName("EncounterTypeID");

                entity.Property(e => e.InventoryItemId).HasColumnName("InventoryItemID");
            });

            modelBuilder.Entity<InventoryItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.InventoryTypeId).HasColumnName("InventoryTypeID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryLocation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InventoryItemId).HasColumnName("InventoryItemID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Price)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ReorderPoint).HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<InventoryPurchase>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Expiration).HasColumnType("datetime");

                entity.Property(e => e.InventoryItemId).HasColumnName("InventoryItemID");

                entity.Property(e => e.InvoiceNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.RecievedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SerialNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Vendor)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InventoryType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IssaScanDoc>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExamDate).HasColumnType("datetime");

                entity.Property(e => e.ExamId).HasColumnName("ExamID");

                entity.Property(e => e.ExpPatientId).HasColumnName("ExpPatientID");

                entity.Property(e => e.FileDesc)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FileName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.IsAvailable).HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");
            });

            modelBuilder.Entity<LabelSize>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<LiveAccountMapping>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LiveIdemail)
                    .HasColumnName("LiveIDEmail")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SiteCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.BarcodeTypeId).HasColumnName("BarcodeTypeID");

                entity.Property(e => e.ColorId).HasColumnName("ColorID");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Ohipnumber)
                    .IsRequired()
                    .HasColumnName("OHIPNumber")
                    .HasMaxLength(4);

                entity.Property(e => e.Prefix)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.RegisterId).HasColumnName("RegisterID");

                entity.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");

                entity.Property(e => e.SiteCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("URL")
                    .HasMaxLength(80);

                entity.HasOne(d => d.BarcodeType)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.BarcodeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_BarcodeType");

                entity.HasOne(d => d.ReportTemplate)
                    .WithMany(p => p.Location)
                    .HasForeignKey(d => d.ReportTemplateId)
                    .HasConstraintName("FK_Location_File");
            });

            modelBuilder.Entity<Locationgroup>(entity =>
            {
                entity.HasKey(e => e.LocationId);

                entity.ToTable("locationgroup");

                entity.Property(e => e.LocationId)
                    .HasColumnName("locationID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Groupid).HasColumnName("groupid");
            });

            modelBuilder.Entity<LocationImageViewers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImageViewerId).HasColumnName("ImageViewerID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ViewerSettings).HasMaxLength(4000);

                entity.HasOne(d => d.ImageViewer)
                    .WithMany(p => p.LocationImageViewers)
                    .HasForeignKey(d => d.ImageViewerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationImageViewers_ImageViewers");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationImageViewers)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationImageViewers_Location");
            });

            modelBuilder.Entity<LocationNextId>(entity =>
            {
                entity.HasKey(e => new { e.LocationId, e.Prefix });

                entity.ToTable("LocationNextID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Prefix)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .HasDefaultValueSql("(' ')");

                entity.Property(e => e.NextId)
                    .HasColumnName("NextID")
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<LocationStaff>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.StaffId).HasColumnName("StaffID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationStaff)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationStaff_Location");

                entity.HasOne(d => d.Staff)
                    .WithMany(p => p.LocationStaff)
                    .HasForeignKey(d => d.StaffId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationStaff_User");
            });

            modelBuilder.Entity<MailMessage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AboutPatientId).HasColumnName("AboutPatientID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.Cclist)
                    .HasColumnName("CCList")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnName("FromUserID");

                entity.Property(e => e.MailContent).IsUnicode(false);

                entity.Property(e => e.MailStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ReadTime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");
            });

            modelBuilder.Entity<MailMessageDeleted>(entity =>
            {
                entity.ToTable("MailMessage_deleted");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AboutPatientId).HasColumnName("AboutPatientID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.Cclist)
                    .HasColumnName("CCList")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedTime).HasColumnType("datetime");

                entity.Property(e => e.FromUserId).HasColumnName("FromUserID");

                entity.Property(e => e.MailContent).IsUnicode(false);

                entity.Property(e => e.MailStatus)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.ReadTime).HasColumnType("datetime");

                entity.Property(e => e.Subject)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ToUserId).HasColumnName("ToUserID");
            });

            modelBuilder.Entity<MaritalStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MergedEncounter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DupPid).HasColumnName("DupPID");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.KeepPid).HasColumnName("KeepPID");
            });

            modelBuilder.Entity<MergeDoctor>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.KeepedId).HasColumnName("KeepedID");

                entity.Property(e => e.MohofficeCode)
                    .HasColumnName("MOHOfficeCode")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Oldid).HasColumnName("oldid");

                entity.Property(e => e.OtherAddressId).HasColumnName("OtherAddressID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.ProviderId).HasColumnName("ProviderID");

                entity.Property(e => e.SignatureImageId).HasColumnName("SignatureImageID");

                entity.Property(e => e.SpecialityId).HasColumnName("SpecialityID");
            });

            modelBuilder.Entity<MergedPatientExtMrn>(entity =>
            {
                entity.ToTable("MergedPatientExtMRN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExpPatientId).HasColumnName("ExpPatientID");

                entity.Property(e => e.ExtMrn)
                    .HasColumnName("ExtMRN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.KeepPid).HasColumnName("KeepPID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");
            });

            modelBuilder.Entity<MergedPrevisit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DupPid).HasColumnName("DupPID");

                entity.Property(e => e.KeepPid).HasColumnName("KeepPID");

                entity.Property(e => e.PreVisitId).HasColumnName("preVisitID");
            });

            modelBuilder.Entity<MergeOperation>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(255);
            });

            modelBuilder.Entity<Messages>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.MsgContent)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.MsgType).HasMaxLength(50);

                entity.Property(e => e.StartDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Mhlcoffice>(entity =>
            {
                entity.ToTable("MHLCOffice");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("char(1)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MissingAccNo>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessionNumber)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId)
                    .HasColumnName("patientID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Mrnbak>(entity =>
            {
                entity.ToTable("MRNBak");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Mrn)
                    .HasColumnName("MRN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");
            });

            modelBuilder.Entity<NextBagNo>(entity =>
            {
                entity.HasKey(e => e.BagType);

                entity.ToTable("NextBagNO");

                entity.Property(e => e.BagType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OffTime>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.IntervalEndTime).HasColumnType("datetime");

                entity.Property(e => e.IntervalStartTime).HasColumnType("datetime");

                entity.Property(e => e.ReasonId).HasColumnName("ReasonID");

                entity.Property(e => e.ReasonNote).HasMaxLength(80);

                entity.Property(e => e.RecurrenceUnitId).HasColumnName("RecurrenceUnitID");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.OffTime)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffTime_Facility");

                entity.HasOne(d => d.Reason)
                    .WithMany(p => p.OffTime)
                    .HasForeignKey(d => d.ReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffTime_OffTimeReason");

                entity.HasOne(d => d.RecurrenceUnit)
                    .WithMany(p => p.OffTime)
                    .HasForeignKey(d => d.RecurrenceUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OffTime_RecurrenceUnit");
            });

            modelBuilder.Entity<OffTimeReason>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<OhipAppointmentCode>(entity =>
            {
                entity.HasIndex(e => e.AppointmentId)
                    .HasName("Idx_OhipAppCode_AppID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.CodeTemplateId).HasColumnName("CodeTemplateID");

                entity.Property(e => e.Comment).HasMaxLength(50);

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.OhipAppointmentCode)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipAppointmentCode_Appointment");

                entity.HasOne(d => d.CodeTemplate)
                    .WithMany(p => p.OhipAppointmentCode)
                    .HasForeignKey(d => d.CodeTemplateId)
                    .HasConstraintName("FK_OhipAppointmentCode_OhipCodeTemplate");
            });

            modelBuilder.Entity<OhipClaim>(entity =>
            {
                entity.HasIndex(e => e.AppointmentCodeId)
                    .HasName("OhipClaim_IDX_2");

                entity.HasIndex(e => new { e.Id, e.AppointmentCodeId })
                    .HasName("idx_OhipClaim_OhipAppCodeID");

                entity.HasIndex(e => new { e.Id, e.AppointmentCodeId, e.ServiceCode, e.ClaimAmount, e.PaidAmount, e.NumberOfServices, e.Suffix, e.StatusId })
                    .HasName("OhipClaim_IDX_StatusID");

                entity.HasIndex(e => new { e.Id, e.AppointmentCodeId, e.ServiceCode, e.ClaimAmount, e.PaidAmount, e.NumberOfServices, e.ServiceDate, e.Hin, e.HinversionCode, e.DiagnosticCode, e.ProviderId, e.IsManualReview, e.Suffix, e.StatusId })
                    .HasName("OhipClaim_IDX_3");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentCodeId).HasColumnName("AppointmentCodeID");

                entity.Property(e => e.ClaimAmount).HasColumnType("money");

                entity.Property(e => e.ClaimAmountInFile).HasColumnType("money");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomAccountingNumber)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DiagnosticCode).HasMaxLength(20);

                entity.Property(e => e.Hin)
                    .IsRequired()
                    .HasColumnName("HIN")
                    .HasMaxLength(11);

                entity.Property(e => e.HinversionCode)
                    .HasColumnName("HINVersionCode")
                    .HasMaxLength(2);

                entity.Property(e => e.IsManualReview).HasColumnName("isManualReview");

                entity.Property(e => e.PaidAmount).HasColumnType("money");

                entity.Property(e => e.ProviderId)
                    .HasColumnName("ProviderID")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.Suffix)
                    .IsRequired()
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.UnPaidResubmit)
                    .HasColumnName("unPaidResubmit")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.AppointmentCode)
                    .WithMany(p => p.OhipClaim)
                    .HasForeignKey(d => d.AppointmentCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipClaim_OhipAppointmentCode");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.OhipClaim)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipClaim_BillingStatus");
            });

            modelBuilder.Entity<OhipClaimFile>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.RejectReason).HasMaxLength(50);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.OhipClaimFile)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipClaimFile_OhipEdtAccount");
            });

            modelBuilder.Entity<OhipClaimFileClaim>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.HasOne(d => d.Claim)
                    .WithMany(p => p.OhipClaimFileClaim)
                    .HasForeignKey(d => d.ClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipClaimFileClaim_OhipClaim");

                entity.HasOne(d => d.Content)
                    .WithMany(p => p.OhipClaimFileClaim)
                    .HasForeignKey(d => d.ContentId)
                    .HasConstraintName("FK_OhipClaimFileClaim_OhipClaimFileContent");
            });

            modelBuilder.Entity<OhipClaimFileContent>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SubmitText).HasMaxLength(500);

                entity.HasOne(d => d.ClaimFile)
                    .WithMany(p => p.OhipClaimFileContent)
                    .HasForeignKey(d => d.ClaimFileId)
                    .HasConstraintName("FK_OhipClaimFileContent_OhipClaimFile");
            });

            modelBuilder.Entity<OhipClaimJob>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountList)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DoctorIdlist)
                    .HasColumnName("DoctorIDList")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.JobCreateTime).HasColumnType("datetime");

                entity.Property(e => e.JobFinishTime).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OhipClaimStatus>(entity =>
            {
                entity.HasIndex(e => new { e.OhipClaimId, e.StatusId })
                    .HasName("OhipClaimStatus_IDX_5");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClaimFileId).HasColumnName("ClaimFileID");

                entity.Property(e => e.OhipClaimId).HasColumnName("OhipClaimID");

                entity.Property(e => e.StatusDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.ClaimFile)
                    .WithMany(p => p.OhipClaimStatus)
                    .HasForeignKey(d => d.ClaimFileId)
                    .HasConstraintName("FK_OhipClaimStatus_OhipClaimFile");

                entity.HasOne(d => d.OhipClaim)
                    .WithMany(p => p.OhipClaimStatus)
                    .HasForeignKey(d => d.OhipClaimId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipClaimStatus_OhipClaim");

                entity.HasOne(d => d.OhipEdtRemittanceAdviceReport)
                    .WithMany(p => p.OhipClaimStatus)
                    .HasForeignKey(d => d.OhipEdtRemittanceAdviceReportId)
                    .HasConstraintName("FK_OhipClaimStatus_OhipEdtRemittanceAdviceReport");

                entity.HasOne(d => d.OhipEdtReport)
                    .WithMany(p => p.OhipClaimStatus)
                    .HasForeignKey(d => d.OhipEdtReportId)
                    .HasConstraintName("FK_OhipClaimStatus_OhipEdtReport");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.OhipClaimStatus)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipClaimStatus_BillingStatus");
            });

            modelBuilder.Entity<OhipCodeTemplate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ControlId).HasColumnName("ControlID");

                entity.HasOne(d => d.Control)
                    .WithMany(p => p.OhipCodeTemplate)
                    .HasForeignKey(d => d.ControlId)
                    .HasConstraintName("FK_OhipCodeTemplate_OhipItemControl");
            });

            modelBuilder.Entity<OhipCodeTemplateItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DiagnosticCode).HasMaxLength(20);

                entity.Property(e => e.NumberOfServices).HasDefaultValueSql("((1))");

                entity.Property(e => e.OhipCodeTemplateId).HasColumnName("OhipCodeTemplateID");

                entity.Property(e => e.OhipServiceCodeId).HasColumnName("OhipServiceCodeID");

                entity.HasOne(d => d.OhipCodeTemplate)
                    .WithMany(p => p.OhipCodeTemplateItem)
                    .HasForeignKey(d => d.OhipCodeTemplateId)
                    .HasConstraintName("FK_OhipCodeTemplateItem_OhipCodeTemplate");

                entity.HasOne(d => d.OhipServiceCode)
                    .WithMany(p => p.OhipCodeTemplateItem)
                    .HasForeignKey(d => d.OhipServiceCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipCodeTemplateItem_OhipServiceCode");
            });

            modelBuilder.Entity<OhipCutOffDate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DateFrom).HasColumnType("datetime");

                entity.Property(e => e.DateTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<OhipEdtAccount>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.DoctorSpecialityId).HasColumnName("DoctorSpecialityID");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.FileNamePrefix)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode).HasColumnType("char(4)");

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.MohofficeCode)
                    .HasColumnName("MOHOfficeCode")
                    .HasColumnType("nchar(1)");

                entity.Property(e => e.NoReport)
                    .HasColumnType("char(1)")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.Resubmit).HasColumnName("resubmit");

                entity.Property(e => e.SecurityCode).HasMaxLength(50);

                entity.Property(e => e.Suffix).HasColumnType("nchar(1)");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.OhipEdtAccount)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_OhipEdtAccount_Doctor");

                entity.HasOne(d => d.DoctorSpeciality)
                    .WithMany(p => p.OhipEdtAccount)
                    .HasForeignKey(d => d.DoctorSpecialityId)
                    .HasConstraintName("FK_OhipEdtAccount_DoctorSpeciality");

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.OhipEdtAccount)
                    .HasForeignKey(d => d.FacilityId)
                    .HasConstraintName("FK_OhipEdtAccount_Facility");
            });

            modelBuilder.Entity<OhipEdtClaimError>(entity =>
            {
                entity.HasIndex(e => new { e.ErrorCodeId, e.OhipClaimStatusId })
                    .HasName("OhipEdtClaimError_IDX_2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ErrorCodeId).HasColumnName("ErrorCodeID");

                entity.Property(e => e.OhipClaimStatusId).HasColumnName("OhipClaimStatusID");

                entity.HasOne(d => d.ErrorCode)
                    .WithMany(p => p.OhipEdtClaimError)
                    .HasForeignKey(d => d.ErrorCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipEdtClaimError_OhipEDTErrorCodes");

                entity.HasOne(d => d.OhipClaimStatus)
                    .WithMany(p => p.OhipEdtClaimError)
                    .HasForeignKey(d => d.OhipClaimStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipEdtClaimError_OhipClaimStatus");
            });

            modelBuilder.Entity<OhipEdtErrorCode>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("nchar(3)");

                entity.Property(e => e.Description).HasMaxLength(2000);

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<OhipEdtRemittanceAdviceReport>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.EdtAccountId).HasColumnName("EdtAccountID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.TotalPaidAmount).HasColumnType("money");

                entity.HasOne(d => d.EdtAccount)
                    .WithMany(p => p.OhipEdtRemittanceAdviceReport)
                    .HasForeignKey(d => d.EdtAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipEdtRemittanceAdviceReport_OhipEdtAccount");
            });

            modelBuilder.Entity<OhipEdtReport>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.EdtAccountId).HasColumnName("EdtAccountID");

                entity.Property(e => e.ErrorMessage).HasMaxLength(255);

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasColumnType("nchar(12)");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.HasOne(d => d.EdtAccount)
                    .WithMany(p => p.OhipEdtReport)
                    .HasForeignKey(d => d.EdtAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipEdtReport_OhipEdtAccount");
            });

            modelBuilder.Entity<OhipEdtSchedule>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OhipEdtAccountId).HasColumnName("OhipEdtAccountID");

                entity.Property(e => e.ScheduleId).HasColumnName("ScheduleID");

                entity.HasOne(d => d.OhipEdtAccount)
                    .WithMany(p => p.OhipEdtSchedule)
                    .HasForeignKey(d => d.OhipEdtAccountId)
                    .HasConstraintName("FK_OhipEdtSchedule_OhipEdtAccount");

                entity.HasOne(d => d.Schedule)
                    .WithMany(p => p.OhipEdtSchedule)
                    .HasForeignKey(d => d.ScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipEdtSchedule_Schedule");
            });

            modelBuilder.Entity<OhipEdtSessionError>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.FailureDate).HasColumnType("datetime");

                entity.Property(e => e.FailureReason).HasMaxLength(200);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.OhipEdtSessionError)
                    .HasForeignKey(d => d.AccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipEdtSessionError_OhipEdtAccount");
            });

            modelBuilder.Entity<OhipEdtSessionHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomText).HasMaxLength(255);

                entity.Property(e => e.SessionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.OhipEdtSessionHistory)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK_OhipEdtSessionHistory_AccountId");

                entity.HasOne(d => d.Result)
                    .WithMany(p => p.OhipEdtSessionHistory)
                    .HasForeignKey(d => d.ResultId)
                    .HasConstraintName("FK_OhipEdtSessionHistory_ResultId");
            });

            modelBuilder.Entity<OhipEdtSessionResult>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<OhipForm>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.TestTypeId).HasColumnName("TestTypeID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.OhipForm)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipForm_Location");

                entity.HasOne(d => d.TestType)
                    .WithMany(p => p.OhipForm)
                    .HasForeignKey(d => d.TestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipForm_TestType");
            });

            modelBuilder.Entity<OhipFormItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.OhipFormId).HasColumnName("OhipFormID");

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.RelColumn).HasDefaultValueSql("((1))");

                entity.Property(e => e.RelRow).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.OhipForm)
                    .WithMany(p => p.OhipFormItem)
                    .HasForeignKey(d => d.OhipFormId)
                    .HasConstraintName("FK_OhipFormItem_OhipForm");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_OhipFormItem_OhipFormItem");
            });

            modelBuilder.Entity<OhipItemControl>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExtName)
                    .HasColumnName("extName")
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.IsAutoTemplateSelection).HasDefaultValueSql("((1))");

                entity.Property(e => e.OhipFormItemId).HasColumnName("OhipFormItemID");

                entity.Property(e => e.PreName).HasMaxLength(50);

                entity.HasOne(d => d.OhipFormItem)
                    .WithMany(p => p.OhipItemControl)
                    .HasForeignKey(d => d.OhipFormItemId)
                    .HasConstraintName("FK_OhipItemControl_OhipFormItem");
            });

            modelBuilder.Entity<OhipPrice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OhipServiceCodeId).HasColumnName("OhipServiceCodeID");

                entity.Property(e => e.Price).HasColumnType("money");

                entity.Property(e => e.Suffix)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.HasOne(d => d.OhipServiceCode)
                    .WithMany(p => p.OhipPrice)
                    .HasForeignKey(d => d.OhipServiceCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OhipPrice_OhipServiceCode");
            });

            modelBuilder.Entity<OhipServiceCode>(entity =>
            {
                entity.HasIndex(e => new { e.Id, e.CodeBase })
                    .HasName("idx_ohipServiceCode_Codebase");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CodeBase)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.Description).HasMaxLength(255);
            });

            modelBuilder.Entity<OhipTechBilling>(entity =>
            {
                entity.HasIndex(e => e.AppointmentId)
                    .HasName("OhipTechBilling_IDX_AppID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.OhipServiceCodeId).HasColumnName("OhipServiceCodeID");

                entity.Property(e => e.Percentage).HasDefaultValueSql("((100))");

                entity.Property(e => e.Suffix).HasMaxLength(10);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<OperationHours>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.HoursFrom).HasColumnType("datetime");

                entity.Property(e => e.HoursTo).HasColumnType("datetime");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.OperationHours)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OperationHours_Location");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.HasIndex(e => e.Number)
                    .HasName("Patient_IDX_Number");

                entity.HasIndex(e => e.Pid)
                    .HasName("Patient_pid_idx");

                entity.HasIndex(e => new { e.Id, e.Number, e.PersonId, e.Active })
                    .HasName("Patient_IDX_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FamilyDoctorId).HasColumnName("FamilyDoctorID");

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Occupation).HasMaxLength(50);

                entity.Property(e => e.Parimrn)
                    .HasColumnName("parimrn")
                    .HasMaxLength(50);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Provider).HasMaxLength(50);

                entity.Property(e => e.ReferenceDoctorId).HasColumnName("ReferenceDoctorID");

                entity.HasOne(d => d.FamilyDoctor)
                    .WithMany(p => p.PatientFamilyDoctor)
                    .HasForeignKey(d => d.FamilyDoctorId)
                    .HasConstraintName("FK_Patient_Doctor_FamilyDoctor");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_Patient_MaritalStatus");

                entity.HasOne(d => d.MergeOperation)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.MergeOperationId)
                    .HasConstraintName("FK_Patient_MergeOperation");

                entity.HasOne(d => d.MergedToPatient)
                    .WithMany(p => p.InverseMergedToPatient)
                    .HasForeignKey(d => d.MergedToPatientId)
                    .HasConstraintName("FK_Patient_Patient");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.Patient)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Patient_Person");

                entity.HasOne(d => d.ReferenceDoctor)
                    .WithMany(p => p.PatientReferenceDoctor)
                    .HasForeignKey(d => d.ReferenceDoctorId)
                    .HasConstraintName("FK_Patient_Doctor");
            });

            modelBuilder.Entity<PatientAllergy>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AllergyId).HasColumnName("AllergyID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.HasOne(d => d.Allergy)
                    .WithMany(p => p.PatientAllergy)
                    .HasForeignKey(d => d.AllergyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientAllergy_Allergy");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientAllergy)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientAllergy_Patient");
            });

            modelBuilder.Entity<PatientBrooklin>(entity =>
            {
                entity.HasKey(e => e.RecordNo);

                entity.Property(e => e.RecordNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.HealthNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sex)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PatientChartNo>(entity =>
            {
                entity.HasKey(e => new { e.PatientId, e.BagNo, e.BagType, e.LocationId });

                entity.ToTable("PatientChartNO");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.BagNo)
                    .HasColumnName("BagNO")
                    .HasMaxLength(15);

                entity.Property(e => e.BagType)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("('XR')");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.HistBagNo)
                    .HasColumnName("HistBagNO")
                    .HasMaxLength(15);

                entity.Property(e => e.HistPreBagNo)
                    .HasColumnName("HistPreBagNO")
                    .HasMaxLength(15);

                entity.Property(e => e.PreBagNo)
                    .HasColumnName("PreBagNO")
                    .HasMaxLength(15)
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientChartNo)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientChartNO_Patient");
            });

            modelBuilder.Entity<PatientDupNoHin>(entity =>
            {
                entity.HasKey(e => e.Mrn);

                entity.ToTable("PatientDupNoHIN");

                entity.Property(e => e.Mrn)
                    .HasColumnName("MRN")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<PatientExtMrn>(entity =>
            {
                entity.ToTable("PatientExtMRN");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ExpPatientId).HasColumnName("ExpPatientID");

                entity.Property(e => e.ExtMrn)
                    .HasColumnName("ExtMRN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hcn)
                    .HasColumnName("HCN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");
            });

            modelBuilder.Entity<PatientHistory>(entity =>
            {
                entity.HasKey(e => e.RecordNo);

                entity.Property(e => e.RecordNo).ValueGeneratedNever();

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.CopyTo).HasMaxLength(30);

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasMaxLength(20);

                entity.Property(e => e.DocChartNo).HasMaxLength(20);

                entity.Property(e => e.ExpiryDate)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName).HasMaxLength(20);

                entity.Property(e => e.FirstVisit).HasMaxLength(20);

                entity.Property(e => e.HealthNo).HasMaxLength(12);

                entity.Property(e => e.LastName).HasMaxLength(25);

                entity.Property(e => e.LastVisit).HasMaxLength(20);

                entity.Property(e => e.Marital).HasMaxLength(1);

                entity.Property(e => e.MiddleName).HasMaxLength(10);

                entity.Property(e => e.Phone1).HasMaxLength(10);

                entity.Property(e => e.Phone2).HasMaxLength(10);

                entity.Property(e => e.PostCode).HasMaxLength(6);

                entity.Property(e => e.PrevXrayNo).HasColumnName("PrevXRayNo");

                entity.Property(e => e.Province).HasMaxLength(25);

                entity.Property(e => e.RefDocNo).HasMaxLength(6);

                entity.Property(e => e.Sex).HasMaxLength(1);

                entity.Property(e => e.Street).HasMaxLength(40);

                entity.Property(e => e.Version).HasMaxLength(2);

                entity.Property(e => e.XrayNo).HasColumnName("XRayNo");
            });

            modelBuilder.Entity<PatientMessage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.MessageType).HasMaxLength(20);

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("updatedDate")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Patient)
                    .WithMany(p => p.PatientMessage)
                    .HasForeignKey(d => d.PatientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PatientMessage_Patient");
            });

            modelBuilder.Entity<PatientPayor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PayorId).HasColumnName("PayorID");

                entity.Property(e => e.PlanId)
                    .HasColumnName("PlanID")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Payor>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<PdfreportQueue>(entity =>
            {
                entity.ToTable("PDFReportQueue");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GenerateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsGenerated).HasColumnName("isGenerated");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasIndex(e => e.Birthday)
                    .HasName("person_dob_idx");

                entity.HasIndex(e => e.LastName)
                    .HasName("Person_ln_idx");

                entity.HasIndex(e => e.Pid)
                    .HasName("person_pid_idx");

                entity.HasIndex(e => new { e.FirstName, e.LastName })
                    .HasName("Person_fn_idx");

                entity.HasIndex(e => new { e.Id, e.Salutation, e.Gender, e.FirstName, e.MiddleName, e.LastName, e.Birthday, e.AddressId, e.CellPhone, e.BusinessPhone, e.Email, e.CardId })
                    .HasName("Person_IDX_CardID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.BusinessPhone).HasMaxLength(50);

                entity.Property(e => e.CardId).HasColumnName("CardID");

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender)
                    .HasColumnType("nchar(1)")
                    .HasDefaultValueSql("('F')");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Login).HasMaxLength(20);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.Password).HasMaxLength(20);

                entity.Property(e => e.PasswordSolt).HasMaxLength(20);

                entity.Property(e => e.Pid).HasColumnName("pid");

                entity.Property(e => e.Salutation)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SecurityAnswer).HasMaxLength(100);

                entity.Property(e => e.SecurityQuestionId).HasColumnName("SecurityQuestionID");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Person_Address");

                entity.HasOne(d => d.Card)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.CardId)
                    .HasConstraintName("FK_Person_Card");

                entity.HasOne(d => d.SecurityQuestion)
                    .WithMany(p => p.Person)
                    .HasForeignKey(d => d.SecurityQuestionId)
                    .HasConstraintName("FK_Person_SecurityQuestion");
            });

            modelBuilder.Entity<PersonRole>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.PersonRole)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonRole_Person");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.PersonRole)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonRole_Role");
            });

            modelBuilder.Entity<PreviousVisit>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BagNo)
                    .IsRequired()
                    .HasColumnName("BagNO")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ExpPatId).HasColumnName("expPatID");

                entity.Property(e => e.LocationId).HasColumnName("locationID");

                entity.Property(e => e.PatientId).HasColumnName("PATIENT_ID");

                entity.Property(e => e.Visitdate)
                    .HasColumnName("visitdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Provider>(entity =>
            {
                entity.HasIndex(e => e.Code)
                    .HasName("idx_provider_code");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Pid).HasColumnName("pid");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RaclaimHeader>(entity =>
            {
                entity.ToTable("RAClaimHeader");

                entity.HasIndex(e => new { e.Id, e.FileId, e.EncounterId })
                    .HasName("RAClaimHeader_IDX_fileID_encID");

                entity.HasIndex(e => new { e.Id, e.FileId, e.ExtEncounterId, e.ClaimNumber, e.AccountNumber, e.ProviderId, e.Specialty, e.LocationCode, e.GroupNumber, e.EncounterId })
                    .HasName("RaClaimHeader_Idx_EncID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountNumber).HasColumnType("nchar(8)");

                entity.Property(e => e.ClaimNumber)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.ExtEncounterId)
                    .HasColumnName("ExtEncounterID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .HasMaxLength(4)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId)
                    .HasColumnName("ProviderID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Specialty)
                    .HasMaxLength(2)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RaclaimItem>(entity =>
            {
                entity.ToTable("RAClaimItem");

                entity.HasIndex(e => new { e.ClaimId, e.FeePaid })
                    .HasName("RAClaimItem_IDX_claimID_FeePaid");

                entity.HasIndex(e => new { e.ClaimId, e.FeeSubmitted, e.FeePaid, e.RaclaimHeaderId })
                    .HasName("RAClaimItem_IDX_HeaderID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClaimDateRange)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ExplanCode)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FeePaid).HasColumnType("money");

                entity.Property(e => e.FeePaidSign)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.FeeSubmitted).HasColumnType("money");

                entity.Property(e => e.PaidDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RaclaimHeaderId).HasColumnName("RAClaimHeaderID");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.HasOne(d => d.RaclaimHeader)
                    .WithMany(p => p.RaclaimItem)
                    .HasForeignKey(d => d.RaclaimHeaderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RAClaimItem_RAClaimHeader");
            });

            modelBuilder.Entity<RadColumnPrefernece>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ColumnName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Radetail>(entity =>
            {
                entity.ToTable("RADetail");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ClaimId).HasColumnName("ClaimID");

                entity.Property(e => e.ErrorCode)
                    .HasMaxLength(20)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.PaidAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RafileId).HasColumnName("RAFileID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");
            });

            modelBuilder.Entity<RadiType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(2);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RadPrefernece>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExtValue)
                    .HasColumnName("extValue")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PreferenceName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Value)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RadserviceSite>(entity =>
            {
                entity.ToTable("RADServiceSite");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocalFolder)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Pacstype)
                    .HasColumnName("PACSType")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PacsviewerUri)
                    .HasColumnName("PACSViewerURI")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SiteName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SiteServiceUri)
                    .HasColumnName("SiteServiceURI")
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rafile>(entity =>
            {
                entity.ToTable("RAFile");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EdtAccountId).HasColumnName("EdtAccountID");

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.Hcount).HasColumnName("HCount");

                entity.Property(e => e.PayeeName).HasMaxLength(50);

                entity.Property(e => e.PayeeTitle).HasMaxLength(10);

                entity.Property(e => e.ProcessDate)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Rcount).HasColumnName("RCount");

                entity.Property(e => e.ReceiveDate).HasColumnType("datetime");

                entity.Property(e => e.Tcount).HasColumnName("TCount");

                entity.Property(e => e.TotalClinicPaidAmount).HasColumnType("money");

                entity.Property(e => e.TotalClinicSubmitAmount).HasColumnType("money");

                entity.Property(e => e.TotalOtherClinic)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalPaidAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalPayableAmount)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotalSubmitAmount).HasColumnType("money");

                entity.Property(e => e.TotalTranscaction)
                    .HasColumnType("money")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Raheader>(entity =>
            {
                entity.ToTable("RAHeader");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountingNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClaimNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.HealthRegistrationNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.LocationNumber)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PatientFirstName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PatientLastName)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentProgram)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ProviderId)
                    .HasColumnName("ProviderID")
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.Specialty)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.VersionCode)
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Raitem>(entity =>
            {
                entity.ToTable("RAItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmountPaid)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AmountPaidSign)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.AmountSubmitted)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ExplanatoryCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.NumberOfService)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.RaheaderId).HasColumnName("RAHeaderID");

                entity.Property(e => e.ServiceCode)
                    .HasMaxLength(6)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceDate)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Ramessage>(entity =>
            {
                entity.HasKey(e => new { e.RafileId, e.SeqNo });

                entity.ToTable("RAMessage");

                entity.Property(e => e.RafileId).HasColumnName("RAFileID");

                entity.Property(e => e.SeqNo).HasColumnName("SeqNO");

                entity.Property(e => e.Message)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RebilledThirdPartyBilling>(entity =>
            {
                entity.ToTable("rebilledThirdPartyBilling");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmountPaid).HasColumnType("money");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.PaymentDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PaymentNotes).HasMaxLength(255);

                entity.Property(e => e.PaymentReceived).HasColumnType("money");

                entity.Property(e => e.Payor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.ServiceCategory)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<RebilledThirdPartyItem>(entity =>
            {
                entity.ToTable("rebilledThirdPartyItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillingId).HasColumnName("BillingID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.OhipClaimId).HasColumnName("OhipClaimID");

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UnitPrice).HasColumnType("money");
            });

            modelBuilder.Entity<RecurrenceUnit>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<RefDoc>(entity =>
            {
                entity.ToTable("refDoc");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FirstName)
                    .HasColumnName("First Name")
                    .HasMaxLength(255);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last name")
                    .HasMaxLength(255);

                entity.Property(e => e.ProviderNumber)
                    .HasColumnName("Provider Number")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<RefDocHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.City).HasMaxLength(25);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(6);

                entity.Property(e => e.FaxNo).HasMaxLength(15);

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.Property(e => e.PhoneNo).HasMaxLength(15);

                entity.Property(e => e.PostCode).HasMaxLength(7);

                entity.Property(e => e.Province).HasMaxLength(10);

                entity.Property(e => e.Street).HasMaxLength(30);
            });

            modelBuilder.Entity<ReferalReportType>(entity =>
            {
                entity.ToTable("referalReportType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Itemname)
                    .HasColumnName("itemname")
                    .HasMaxLength(101);
            });

            modelBuilder.Entity<ReferralDoctorGroupWeb>(entity =>
            {
                entity.ToTable("ReferralDoctorGroup_Web");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.PrimaryProviderCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Token)
                    .HasColumnName("token")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReferralGroup>(entity =>
            {
                entity.HasKey(e => new { e.GroupId, e.DoctorId });

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReferralPortalGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPhone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GroupUserName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PacUserId)
                    .HasColumnName("PacUserID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrimaryDoctorId).HasColumnName("PrimaryDoctorID");
            });

            modelBuilder.Entity<ReferralRequest>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmedDate).HasColumnType("datetime");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsArchived).HasColumnName("isArchived");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReferralDocId).HasColumnName("ReferralDocID");

                entity.Property(e => e.ReferralGroupId).HasColumnName("ReferralGroupID");

                entity.Property(e => e.RequestDate).HasColumnType("datetime");

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Pending')");
            });

            modelBuilder.Entity<ReferralRequestServiceItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ReferalReportTypeId).HasColumnName("ReferalReportTypeID");

                entity.Property(e => e.ReferralRequestId).HasColumnName("ReferralRequestID");
            });

            modelBuilder.Entity<Register>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<RegisterSpeciality>(entity =>
            {
                entity.HasKey(e => new { e.RegisterId, e.SpecialityId });

                entity.Property(e => e.RegisterId).HasColumnName("RegisterID");

                entity.Property(e => e.SpecialityId).HasColumnName("SpecialityID");

                entity.HasOne(d => d.Register)
                    .WithMany(p => p.RegisterSpeciality)
                    .HasForeignKey(d => d.RegisterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterSpeciality_Register");

                entity.HasOne(d => d.Speciality)
                    .WithMany(p => p.RegisterSpeciality)
                    .HasForeignKey(d => d.SpecialityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RegisterSpeciality_Speciality");
            });

            modelBuilder.Entity<RejectNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.EntryUserId).HasColumnName("EntryUserID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Note)
                    .HasMaxLength(1450)
                    .IsUnicode(false);

                entity.Property(e => e.NoteId).HasColumnName("NoteID");

                entity.Property(e => e.ReadTime).HasColumnType("datetime");

                entity.Property(e => e.ReadUserId).HasColumnName("ReadUserID");
            });

            modelBuilder.Entity<RepeatedWorklistItems>(entity =>
            {
                entity.HasKey(e => e.AppointmentId);

                entity.Property(e => e.AppointmentId)
                    .HasColumnName("AppointmentID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessionNumber)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.RadiologyDoctorId).HasColumnName("RadiologyDoctorID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");

                entity.Property(e => e.Transtatus).HasColumnName("transtatus");
            });

            modelBuilder.Entity<ReportDeliveryLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.ReportDeliveryMethodId).HasColumnName("ReportDeliveryMethodID");

                entity.Property(e => e.ReportDeliveryPriorityId).HasColumnName("ReportDeliveryPriorityID");

                entity.Property(e => e.ReportDeliveryQueueId).HasColumnName("ReportDeliveryQueueID");

                entity.Property(e => e.ReportDeliveryStatusId).HasColumnName("ReportDeliveryStatusID");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.ReportDeliveryMethod)
                    .WithMany(p => p.ReportDeliveryLog)
                    .HasForeignKey(d => d.ReportDeliveryMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDeliveryLog_ReportDeliveryMethod");

                entity.HasOne(d => d.ReportDeliveryPriority)
                    .WithMany(p => p.ReportDeliveryLog)
                    .HasForeignKey(d => d.ReportDeliveryPriorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDeliveryLog_ReportDeliveryPriority");

                entity.HasOne(d => d.ReportDeliveryQueue)
                    .WithMany(p => p.ReportDeliveryLog)
                    .HasForeignKey(d => d.ReportDeliveryQueueId)
                    .HasConstraintName("FK_ReportDeliveryLog_ReportDeliveryQueue");

                entity.HasOne(d => d.ReportDeliveryStatus)
                    .WithMany(p => p.ReportDeliveryLog)
                    .HasForeignKey(d => d.ReportDeliveryStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDeliveryLog_ReportDeliveryStatus");

                entity.HasOne(d => d.Transcription)
                    .WithMany(p => p.ReportDeliveryLog)
                    .HasForeignKey(d => d.TranscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDeliveryLog_Transcription");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportDeliveryLog)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ReportDeliveryLog_User");
            });

            modelBuilder.Entity<ReportDeliveryMethod>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ReportDeliveryPriority>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Priority)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ReportDeliveryQueue>(entity =>
            {
                entity.HasIndex(e => new { e.ReportDeliveryMethodId, e.ReportDeliveryStatusId })
                    .HasName("ReportDeliveryQueue_MthdID_StsID");

                entity.HasIndex(e => new { e.TranscriptionId, e.DoctorId, e.ReportDeliveryMethodId, e.ReportFileId })
                    .HasName("ReportDeliveryQueue_IDX_4");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Attempt).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.ExecutingJobId).HasMaxLength(50);

                entity.Property(e => e.ExecutingJobStarted).HasColumnType("datetime");

                entity.Property(e => e.FaxOrEmail).HasMaxLength(255);

                entity.Property(e => e.NumberOfRetry).HasDefaultValueSql("((3))");

                entity.Property(e => e.ReportDeliveryMethodId).HasColumnName("ReportDeliveryMethodID");

                entity.Property(e => e.ReportDeliveryPriorityId)
                    .HasColumnName("ReportDeliveryPriorityID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.ReportDeliveryStatusId).HasColumnName("ReportDeliveryStatusID");

                entity.Property(e => e.ReportFileId).HasColumnName("ReportFileID");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.ReportDeliveryQueue)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDeliveryQueue_Doctor");

                entity.HasOne(d => d.ReportDeliveryMethod)
                    .WithMany(p => p.ReportDeliveryQueue)
                    .HasForeignKey(d => d.ReportDeliveryMethodId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDeliveryQueue_ReportDeliveryMethod");

                entity.HasOne(d => d.ReportDeliveryPriority)
                    .WithMany(p => p.ReportDeliveryQueue)
                    .HasForeignKey(d => d.ReportDeliveryPriorityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDeliveryQueue_ReportDeliveryPriority");

                entity.HasOne(d => d.ReportDeliveryStatus)
                    .WithMany(p => p.ReportDeliveryQueue)
                    .HasForeignKey(d => d.ReportDeliveryStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDeliveryQueue_ReportDeliveryStatus");

                entity.HasOne(d => d.Transcription)
                    .WithMany(p => p.ReportDeliveryQueue)
                    .HasForeignKey(d => d.TranscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportDeliveryQueue_Transcription");
            });

            modelBuilder.Entity<ReportDeliveryQueueJobStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompleteTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.JobId)
                    .HasColumnName("JobID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.JobStatusId).HasColumnName("JobStatusID");

                entity.Property(e => e.LongStatus)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ReportDeliveryQueueId).HasColumnName("ReportDeliveryQueueID");

                entity.Property(e => e.ResponseString)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ResponseTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SentTime)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReportDeliverySettings>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.EmailBody).HasMaxLength(255);

                entity.Property(e => e.EmailSender)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.EmailSubject).HasMaxLength(255);

                entity.Property(e => e.FaxSender).HasMaxLength(255);

                entity.Property(e => e.FaxServer)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpPassword).HasMaxLength(255);

                entity.Property(e => e.SmtpServer)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SmtpUser).HasMaxLength(255);
            });

            modelBuilder.Entity<ReportDeliveryStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ReportingServicesSettings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DetailedReportPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ReportServerPassword).HasMaxLength(50);

                entity.Property(e => e.ReportServerUrl)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ReportServerUser).HasMaxLength(50);

                entity.Property(e => e.SummaryReportByDoctorPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.SummaryReportByLocationPath)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<ReportLocationGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");
            });

            modelBuilder.Entity<ReportTemplate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.BodyPartId).HasColumnName("BodyPartID");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.FileId).HasColumnName("FileID");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShared).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.RadiTypeId).HasColumnName("RadiTypeID");

                entity.Property(e => e.ReportTemplateKeywordId).HasColumnName("ReportTemplateKeywordID");

                entity.Property(e => e.TestTypeId).HasColumnName("TestTypeID");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.ReportTemplate)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_ReportTemplate_Doctor");

                entity.HasOne(d => d.File)
                    .WithMany(p => p.ReportTemplate)
                    .HasForeignKey(d => d.FileId)
                    .HasConstraintName("FK_ReportTemplate_File");

                entity.HasOne(d => d.ReportTemplateKeyword)
                    .WithMany(p => p.ReportTemplate)
                    .HasForeignKey(d => d.ReportTemplateKeywordId)
                    .HasConstraintName("FK_ReportTemplate_ReportTemplateKeyword");

                entity.HasOne(d => d.TestType)
                    .WithMany(p => p.ReportTemplate)
                    .HasForeignKey(d => d.TestTypeId)
                    .HasConstraintName("FK_ReportTemplate_TestType");
            });

            modelBuilder.Entity<ReportTemplateBody>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Body).IsUnicode(false);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ReportTemplateKeywordId).HasColumnName("ReportTemplateKeywordID");

                entity.Property(e => e.TestTypeId).HasColumnName("TestTypeID");
            });

            modelBuilder.Entity<ReportTemplateKeyword>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Keywords)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.NameSet)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ReportTemplateMapping>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OhipServiceCodeBase)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OhipServiceCodeId).HasColumnName("OhipServiceCodeID");

                entity.Property(e => e.ReportTemplateId).HasColumnName("ReportTemplateID");
            });

            modelBuilder.Entity<ReportViewStatus>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");

                entity.Property(e => e.ViewDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ViewStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Schedule>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActionTime).HasColumnType("datetime");

                entity.Property(e => e.RecurrenceUnitId).HasColumnName("RecurrenceUnitID");

                entity.Property(e => e.ScheduleWorkId).HasColumnName("ScheduleWorkID");

                entity.Property(e => e.ValidFrom).HasColumnType("datetime");

                entity.Property(e => e.ValidTo).HasColumnType("datetime");

                entity.HasOne(d => d.RecurrenceUnit)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.RecurrenceUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_RecurrenceUnit");

                entity.HasOne(d => d.ScheduleWork)
                    .WithMany(p => p.Schedule)
                    .HasForeignKey(d => d.ScheduleWorkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Schedule_ScheduleWork");
            });

            modelBuilder.Entity<ScheduleTemplate>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FacilityId).HasColumnName("FacilityID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.HasOne(d => d.Facility)
                    .WithMany(p => p.ScheduleTemplate)
                    .HasForeignKey(d => d.FacilityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTemplate_Facility");
            });

            modelBuilder.Entity<ScheduleTemplateRecord>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EncounterTypeId).HasColumnName("EncounterTypeID");

                entity.Property(e => e.IntervalEndTime).HasColumnType("datetime");

                entity.Property(e => e.IntervalStartTime).HasColumnType("datetime");

                entity.Property(e => e.TemplateId).HasColumnName("TemplateID");

                entity.HasOne(d => d.EncounterType)
                    .WithMany(p => p.ScheduleTemplateRecord)
                    .HasForeignKey(d => d.EncounterTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTemplateRecord_EncounterType");

                entity.HasOne(d => d.Template)
                    .WithMany(p => p.ScheduleTemplateRecord)
                    .HasForeignKey(d => d.TemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ScheduleTemplateRecord_ScheduleTemplate");
            });

            modelBuilder.Entity<ScheduleWork>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.LastRunTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<SecurityQuestion>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Question)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<SitePreference>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Scope)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Value)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Speciality>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<SysKeys>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.KeyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KeyValue)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TablesChangedByMerge>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ChangedFieldName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.KeyFieldName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.MergeOperationId).HasColumnName("MergeOperationID");

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.MergeOperation)
                    .WithMany(p => p.TablesChangedByMerge)
                    .HasForeignKey(d => d.MergeOperationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TablesChangedByMerge_MergeOperation");
            });

            modelBuilder.Entity<TechNote>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FrmRevId).HasColumnName("FrmRevID");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechNoteItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.FieldContent)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName).HasMaxLength(80);

                entity.Property(e => e.FieldType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FieldValue).HasMaxLength(250);

                entity.Property(e => e.FormId).HasColumnName("FormID");
            });

            modelBuilder.Entity<TestType>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DefaultLabelCopy).HasDefaultValueSql("((2))");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.RadiTypeId).HasColumnName("RadiTypeID");

                entity.Property(e => e.RegisterId).HasColumnName("RegisterID");

                entity.Property(e => e.TypeCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.WorkListName).HasMaxLength(50);

                entity.HasOne(d => d.RadiType)
                    .WithMany(p => p.TestType)
                    .HasForeignKey(d => d.RadiTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestType_RadiType");

                entity.HasOne(d => d.Register)
                    .WithMany(p => p.TestType)
                    .HasForeignKey(d => d.RegisterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestType_Register");
            });

            modelBuilder.Entity<TestTypeReportDoctor>(entity =>
            {
                entity.HasKey(e => new { e.TestTypeId, e.DoctorId });

                entity.Property(e => e.TestTypeId).HasColumnName("TestTypeID");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.TestTypeReportDoctor)
                    .HasForeignKey(d => d.DoctorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestTypeReportDoctor_User");

                entity.HasOne(d => d.TestType)
                    .WithMany(p => p.TestTypeReportDoctor)
                    .HasForeignKey(d => d.TestTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TestTypeReportDoctor_TestType");
            });

            modelBuilder.Entity<ThirdPartyBilling>(entity =>
            {
                entity.HasIndex(e => e.EncounterId)
                    .HasName("IX_ThirdPartyBilling_EncounterID")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AmountPaid).HasColumnType("money");

                entity.Property(e => e.ClaimFormNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Copay).HasDefaultValueSql("((0))");

                entity.Property(e => e.Currency)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('AED')");

                entity.Property(e => e.Discount).HasDefaultValueSql("((100))");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PaymentNotes).HasMaxLength(255);

                entity.Property(e => e.PaymentReceived).HasColumnType("money");

                entity.Property(e => e.Payor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.PayorId).HasColumnName("payorID");

                entity.Property(e => e.ServiceCategory)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.HasOne(d => d.Encounter)
                    .WithOne(p => p.ThirdPartyBilling)
                    .HasForeignKey<ThirdPartyBilling>(d => d.EncounterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ThirdPartyBilling_Encounter");
            });

            modelBuilder.Entity<ThirdPartyBillingItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillingId).HasColumnName("BillingID");

                entity.Property(e => e.Copay).HasColumnType("money");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Discount).HasColumnType("money");

                entity.Property(e => e.GrandAmount).HasColumnType("money");

                entity.Property(e => e.InsCopay).HasColumnType("money");

                entity.Property(e => e.InsPaidAmount).HasColumnType("money");

                entity.Property(e => e.OhipClaimId).HasColumnName("OhipClaimID");

                entity.Property(e => e.PatientCopay).HasColumnType("money");

                entity.Property(e => e.PatientPaidAmount).HasColumnType("money");

                entity.Property(e => e.ServiceCode)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.UnitPrice).HasColumnType("money");

                entity.HasOne(d => d.Billing)
                    .WithMany(p => p.ThirdPartyBillingItem)
                    .HasForeignKey(d => d.BillingId)
                    .HasConstraintName("FK_ThirdPartyBillingItem_ThirdPartyBilling");
            });

            modelBuilder.Entity<ThirdPartyInvoice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthCode).HasMaxLength(80);

                entity.Property(e => e.ClaimAmount).HasColumnType("money");

                entity.Property(e => e.CopayAmount).HasColumnType("money");

                entity.Property(e => e.Discount).HasColumnType("decimal(11, 2)");

                entity.Property(e => e.DiscountAmount).HasColumnType("money");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.NetAmount).HasColumnType("money");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PayorId).HasColumnName("PayorID");

                entity.Property(e => e.TotalAmount).HasColumnType("money");

                entity.Property(e => e.VerbalCode).HasMaxLength(80);
            });

            modelBuilder.Entity<ThirdPartyPayment>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Balance).HasColumnType("money");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.InvoiceId).HasColumnName("invoiceID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PaymentAmount).HasColumnType("money");

                entity.Property(e => e.PaymentDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PaymentMethodId).HasColumnName("PaymentMethodID");

                entity.Property(e => e.PayorId).HasColumnName("PayorID");

                entity.Property(e => e.PreviousBalance).HasColumnType("money");

                entity.Property(e => e.Warning).HasColumnName("warning");
            });

            modelBuilder.Entity<ThirdPartyPaymentItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.BillingId).HasColumnName("BillingID");

                entity.Property(e => e.PaymentAmount).HasColumnType("money");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.PayorId).HasColumnName("PayorID");
            });

            modelBuilder.Entity<ThirdPartyPaymentMethod>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.SortOrder).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<ThirdPartyPayor>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddressLine1).HasMaxLength(250);

                entity.Property(e => e.AddressLine2).HasMaxLength(250);

                entity.Property(e => e.Fax)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TmpTableDrclaim>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.ToTable("tmpTableDRClaim");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("DoctorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaimAmount).HasColumnType("money");

                entity.Property(e => e.Suffix)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TesttypeId).HasColumnName("testtypeID");
            });

            modelBuilder.Entity<TmpTableDrclaim1>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.ToTable("tmpTableDRClaim1");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("DoctorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaimAmount).HasColumnType("money");

                entity.Property(e => e.Suffix)
                    .IsRequired()
                    .HasMaxLength(1);

                entity.Property(e => e.TesttypeId).HasColumnName("testtypeID");
            });

            modelBuilder.Entity<TmpTableDrpatient>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.ToTable("tmpTableDRPatient");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("DoctorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ModalityName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.TesttypeId).HasColumnName("testtypeID");
            });

            modelBuilder.Entity<TmpTableEncId>(entity =>
            {
                entity.ToTable("tmpTableEncID");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();
            });

            modelBuilder.Entity<TmpTablerefDrTable>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.ToTable("tmpTablerefDrTable");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("DoctorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Drname)
                    .IsRequired()
                    .HasColumnName("DRName")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModalityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProFee).HasColumnType("money");

                entity.Property(e => e.ProviderId)
                    .HasColumnName("ProviderID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TechFee).HasColumnType("money");

                entity.Property(e => e.TotalFee).HasColumnType("money");
            });

            modelBuilder.Entity<TmpTablereferralReport>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.ToTable("tmpTablereferralReport");

                entity.Property(e => e.DoctorId)
                    .HasColumnName("DoctorID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Drname)
                    .HasColumnName("DRName")
                    .HasMaxLength(102);

                entity.Property(e => e.ModalityName)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ProviderId)
                    .IsRequired()
                    .HasColumnName("ProviderID")
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.TesttypeId).HasColumnName("testtypeID");
            });

            modelBuilder.Entity<TranApprovedId>(entity =>
            {
                entity.ToTable("TranApprovedID");

                entity.Property(e => e.Id).HasColumnName("ID");
            });

            modelBuilder.Entity<Transcription>(entity =>
            {
                entity.HasIndex(e => e.AppId)
                    .HasName("Transcription_IDX_appID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppId).HasColumnName("AppID");

                entity.Property(e => e.ApprovedById).HasColumnName("ApprovedByID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.OldTranId).HasColumnName("oldTranID");

                entity.Property(e => e.PdfFileId).HasColumnName("PdfFileID");

                entity.Property(e => e.ReportFileId).HasColumnName("ReportFileID");

                entity.Property(e => e.ReportFormat)
                    .HasColumnName("reportFormat")
                    .HasColumnType("char(1)");

                entity.Property(e => e.StatusId)
                    .HasColumnName("StatusID")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.ApprovedBy)
                    .WithMany(p => p.TranscriptionApprovedBy)
                    .HasForeignKey(d => d.ApprovedById)
                    .HasConstraintName("FK_Transcription_User1");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.TranscriptionCreatedBy)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transcription_User");

                entity.HasOne(d => d.PdfFile)
                    .WithMany(p => p.TranscriptionPdfFile)
                    .HasForeignKey(d => d.PdfFileId)
                    .HasConstraintName("FK_Transcription_PdfFile");

                entity.HasOne(d => d.ReportFile)
                    .WithMany(p => p.TranscriptionReportFile)
                    .HasForeignKey(d => d.ReportFileId)
                    .HasConstraintName("FK_Transcription_File");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Transcription)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Transcription_TranscriptionStatus");
            });

            modelBuilder.Entity<TranscriptionAddendum>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppId).HasColumnName("AppID");

                entity.Property(e => e.ApprovedById).HasColumnName("ApprovedByID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Note)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.OldTranId).HasColumnName("oldTranID");

                entity.Property(e => e.PdfFileId).HasColumnName("PdfFileID");

                entity.Property(e => e.ReportBody).IsUnicode(false);

                entity.Property(e => e.ReportFileId).HasColumnName("ReportFileID");

                entity.Property(e => e.ReportFormat)
                    .HasColumnName("reportFormat")
                    .HasColumnType("char(1)");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");
            });

            modelBuilder.Entity<TranscriptionBody>(entity =>
            {
                entity.HasIndex(e => e.TranscriptionId)
                    .HasName("TranscriptionBody_IDX_1");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.OldTranId).HasColumnName("oldTranID");

                entity.Property(e => e.ReportBody).IsUnicode(false);

                entity.Property(e => e.ReportText).IsUnicode(false);

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<TranscriptionError>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.TranscriptionError)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TranscriptionError_Appointment");

                entity.HasOne(d => d.Transcription)
                    .WithMany(p => p.TranscriptionError)
                    .HasForeignKey(d => d.TranscriptionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TranscriptionError_Transcription");
            });

            modelBuilder.Entity<TranscriptionHistory>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.ReportBody).IsUnicode(false);

                entity.Property(e => e.ReportText).IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");

                entity.Property(e => e.UpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<TranscriptionStatus>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<TranscriptionUpdateLog>(entity =>
            {
                entity.HasIndex(e => e.AppointmentId)
                    .HasName("TranscriptionUpdateLog_Idx_appID");

                entity.HasIndex(e => e.TranscriptionId)
                    .HasName("TranscriptionUpdateLog_idx_tranID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.MethodId).HasColumnName("methodID");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");

                entity.Property(e => e.UpdateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TravelTime>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LocationFromId).HasColumnName("LocationFromID");

                entity.Property(e => e.LocationToId).HasColumnName("LocationToID");

                entity.Property(e => e.TravelTime1)
                    .HasColumnName("TravelTime")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.LocationFrom)
                    .WithMany(p => p.TravelTimeLocationFrom)
                    .HasForeignKey(d => d.LocationFromId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TravelTime_Location");

                entity.HasOne(d => d.LocationTo)
                    .WithMany(p => p.TravelTimeLocationTo)
                    .HasForeignKey(d => d.LocationToId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TravelTime_Location1");
            });

            modelBuilder.Entity<TypistLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.DictationTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<UniqueNumber>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<UpdatedTranscriptionBody>(entity =>
            {
                entity.HasKey(e => e.FacilityId);

                entity.Property(e => e.FacilityId)
                    .HasColumnName("FacilityID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AccessionNumber)
                    .IsRequired()
                    .HasMaxLength(12);

                entity.Property(e => e.AppointmentId).HasColumnName("appointmentID");

                entity.Property(e => e.CreatedById).HasColumnName("CreatedByID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EncounterId).HasColumnName("EncounterID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastUpdatedTime).HasColumnType("datetime");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PdfFileId).HasColumnName("PdfFileID");

                entity.Property(e => e.RadiologyDoctorId).HasColumnName("RadiologyDoctorID");

                entity.Property(e => e.ReportBody).IsUnicode(false);

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.TranscriptionId).HasColumnName("TranscriptionID");

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");

                entity.Property(e => e.VisitNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DictationDeviceId)
                    .HasColumnName("DictationDeviceID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DoctorId).HasColumnName("DoctorID");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasColumnName("EmployeeID")
                    .HasMaxLength(20);

                entity.Property(e => e.HireDate).HasColumnType("datetime");

                entity.Property(e => e.HourlyRate).HasColumnType("money");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsEchoDr).HasColumnName("isEchoDr");

                entity.Property(e => e.IsExternalNetwork)
                    .HasColumnName("isExternalNetwork")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LetterSignature).HasMaxLength(80);

                entity.Property(e => e.MhlcofficeId).HasColumnName("MHLCOfficeID");

                entity.Property(e => e.Pager).HasMaxLength(50);

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.PracticeAddressId).HasColumnName("PracticeAddressID");

                entity.Property(e => e.RegisterId).HasColumnName("RegisterID");

                entity.Property(e => e.RestrictedReportFlag).HasDefaultValueSql("((1))");

                entity.Property(e => e.RisSessionId)
                    .HasColumnName("risSessionID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sin).HasColumnName("SIN");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserSettingsId).HasColumnName("UserSettingsID");

                entity.HasOne(d => d.DictationDevice)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.DictationDeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_DictationDevice");

                entity.HasOne(d => d.Doctor)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.DoctorId)
                    .HasConstraintName("FK_User_Doctor");

                entity.HasOne(d => d.Mhlcoffice)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.MhlcofficeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_MHLCOffice");

                entity.HasOne(d => d.Person)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.PersonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Person");

                entity.HasOne(d => d.PracticeAddress)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.PracticeAddressId)
                    .HasConstraintName("FK_User_Address");

                entity.HasOne(d => d.Register)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RegisterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Register");

                entity.HasOne(d => d.UserSettings)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.UserSettingsId)
                    .HasConstraintName("FK_User_UserSettings");
            });

            modelBuilder.Entity<UserCurAccNo>(entity =>
            {
                entity.ToTable("userCurAccNO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Accno)
                    .HasColumnName("accno")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsCurrent)
                    .HasColumnName("isCurrent")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastChangeTime)
                    .HasColumnName("lastChangeTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.PatientId)
                    .HasColumnName("patientID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Visitdate)
                    .HasColumnName("visitdate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<UserImageViewers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AuthToken)
                    .HasColumnName("authToken")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ImageViewerId).HasColumnName("ImageViewerID");

                entity.Property(e => e.PacsUser)
                    .HasColumnName("pacsUser")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SessionId)
                    .HasColumnName("sessionID")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Settings).HasMaxLength(2000);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ImageViewer)
                    .WithMany(p => p.UserImageViewers)
                    .HasForeignKey(d => d.ImageViewerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserImageViewers_ImageViewers");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserImageViewers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserImageViewers_User");
            });

            modelBuilder.Entity<UserPrefernece>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .ValueGeneratedNever();

                entity.Property(e => e.LaunchPlayer)
                    .HasColumnName("launchPlayer")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LaunchRecorder).HasColumnName("launchRecorder");

                entity.Property(e => e.LaunchRequisition).HasColumnName("launchRequisition");

                entity.Property(e => e.LaunchViewer).HasColumnName("launchViewer");

                entity.Property(e => e.LayoutString).IsUnicode(false);
            });

            modelBuilder.Entity<UserSession>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IsExpired).HasColumnName("isExpired");

                entity.Property(e => e.RisSessionId)
                    .HasColumnName("risSessionID")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SessionCreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SessionId)
                    .HasColumnName("SessionID")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SessionLastDate).HasColumnType("datetime");

                entity.Property(e => e.UserViewerId).HasColumnName("UserViewerID");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<UserSettings>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EncounterIconsSettingsId).HasColumnName("EncounterIconsSettingsID");

                entity.HasOne(d => d.EncounterIconsSettings)
                    .WithMany(p => p.UserSettings)
                    .HasForeignKey(d => d.EncounterIconsSettingsId)
                    .HasConstraintName("FK_UserSettings_EncounterIconsSettings");
            });

            modelBuilder.Entity<VoiceRecord>(entity =>
            {
                entity.HasIndex(e => e.AppointmentId)
                    .HasName("VoiceRecord_idx_appID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AppointmentId).HasColumnName("AppointmentID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Appointment)
                    .WithMany(p => p.VoiceRecord)
                    .HasForeignKey(d => d.AppointmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VoiceRecord_Appointment");

                entity.HasOne(d => d.AudioFile)
                    .WithMany(p => p.VoiceRecord)
                    .HasForeignKey(d => d.AudioFileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VoiceRecord_File");

                entity.HasOne(d => d.CreatedBy)
                    .WithMany(p => p.VoiceRecord)
                    .HasForeignKey(d => d.CreatedById)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_VoiceRecord_User");
            });

            modelBuilder.Entity<VReadingDoctor>(entity =>
            {
                entity.ToTable("vReadingDoctor");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressId).HasColumnName("AddressID");

                entity.Property(e => e.AddressLine)
                    .IsRequired()
                    .HasMaxLength(250);

                entity.Property(e => e.AsproviderId)
                    .IsRequired()
                    .HasColumnName("ASProviderID")
                    .HasColumnType("nchar(6)");

                entity.Property(e => e.Birthday).HasColumnType("datetime");

                entity.Property(e => e.BusinessPhone).HasMaxLength(50);

                entity.Property(e => e.CellPhone).HasMaxLength(50);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Gender).HasColumnType("nchar(1)");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.MohofficeCode)
                    .HasColumnName("MOHOfficeCode")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.OtherAddressId).HasColumnName("OtherAddressID");

                entity.Property(e => e.PersonId).HasColumnName("PersonID");

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PostCode).HasMaxLength(10);

                entity.Property(e => e.ProvinceCode)
                    .HasColumnName("provinceCode")
                    .HasMaxLength(2);

                entity.Property(e => e.ProvinceId).HasColumnName("ProvinceID");

                entity.Property(e => e.Salutation)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SpecialityCode)
                    .IsRequired()
                    .HasColumnName("specialityCode")
                    .HasMaxLength(2);

                entity.Property(e => e.SpecialityNmae)
                    .IsRequired()
                    .HasColumnName("specialityNmae")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<WaitingListGroup>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.History)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InQueueDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PatientId).HasColumnName("PatientID");

                entity.Property(e => e.PayorId).HasColumnName("PayorID");

                entity.Property(e => e.RefDrId).HasColumnName("RefDrID");

                entity.Property(e => e.StartWaitingDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.VisitReason)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<WaitingListItem>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EnctypeId).HasColumnName("EnctypeID");

                entity.Property(e => e.FacilityId)
                    .HasColumnName("FacilityID")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");
            });

            modelBuilder.Entity<WorklistFilter>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AssignStatus).HasDefaultValueSql("('0')");

                entity.Property(e => e.Doctors)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.FilterName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasColumnName("isActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsShared).HasColumnName("isShared");

                entity.Property(e => e.Locations)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ReportStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('1,2,3')");

                entity.Property(e => e.TestTypes)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TimePeriod).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<WorksheetMapping>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FormFieldName).HasMaxLength(255);

                entity.Property(e => e.FormRevId).HasColumnName("FormRevID");

                entity.Property(e => e.MergeFieldName).HasMaxLength(255);

                entity.Property(e => e.TemplateName).HasMaxLength(255);
            });
        }
    }
}
