IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [JobClassifications] (
        [jobClassificationId] int NOT NULL IDENTITY,
        [occupationalServCode] nvarchar(10) NULL,
        [occupationalDesc] nvarchar(200) NULL,
        [occupationalGrpCode] nvarchar(10) NULL,
        [occupationalGrpDesc] nvarchar(200) NULL,
        [classCode] nvarchar(20) NULL,
        [classDesc] nvarchar(200) NULL,
        [salary_grade] int NOT NULL,
        [is_active] bit NOT NULL,
        CONSTRAINT [PK_JobClassifications] PRIMARY KEY ([jobClassificationId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [JobRequisitions] (
        [requisitionId] uniqueidentifier NOT NULL,
        [requestDate] datetime2 NOT NULL,
        [requestTypeId] int NOT NULL,
        [departmentId] int NOT NULL,
        [locationAddress] nvarchar(max) NULL,
        [jobCategoryId] int NOT NULL,
        [jobTitle] nvarchar(max) NULL,
        [salary] decimal(18,2) NOT NULL,
        [jobDescription] nvarchar(max) NULL,
        [qualification] nvarchar(max) NULL,
        [isOpen] bit NOT NULL,
        [isApproved] bit NOT NULL,
        [closingDate] datetime2 NOT NULL,
        [deleted_by] nvarchar(max) NULL,
        [deleted_date] datetime2 NULL,
        [is_deleted] bit NOT NULL,
        CONSTRAINT [PK_JobRequisitions] PRIMARY KEY ([requisitionId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [LDNADetails] (
        [ldnaId] uniqueidentifier NOT NULL,
        [departmentId] int NOT NULL,
        CONSTRAINT [PK_LDNADetails] PRIMARY KEY ([ldnaId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Barangays] (
        [brgy_code] nvarchar(450) NOT NULL,
        [rowid] int NOT NULL IDENTITY,
        [city_code] nvarchar(max) NULL,
        [brgy_name] nvarchar(max) NULL,
        [sortOrder] int NULL,
        CONSTRAINT [PK_Lib_Barangays] PRIMARY KEY ([brgy_code])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Blood_Types] (
        [blood_type_id] int NOT NULL IDENTITY,
        [description] nvarchar(max) NULL,
        CONSTRAINT [PK_Lib_Blood_Types] PRIMARY KEY ([blood_type_id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Cities] (
        [city_code] nvarchar(450) NOT NULL,
        [rowid] int NOT NULL IDENTITY,
        [prov_code] nvarchar(max) NULL,
        [city_name] nvarchar(max) NULL,
        [sortOrder] int NULL,
        CONSTRAINT [PK_Lib_Cities] PRIMARY KEY ([city_code])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Citizenships] (
        [citizenship_id] int NOT NULL IDENTITY,
        [description] nvarchar(max) NULL,
        CONSTRAINT [PK_Lib_Citizenships] PRIMARY KEY ([citizenship_id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Civil_Statuses] (
        [civil_status_id] int NOT NULL IDENTITY,
        [description] nvarchar(max) NULL,
        CONSTRAINT [PK_Lib_Civil_Statuses] PRIMARY KEY ([civil_status_id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Core_Competencies] (
        [coreCompetencyId] int NOT NULL IDENTITY,
        [description] nvarchar(max) NULL,
        [is_active] bit NOT NULL,
        CONSTRAINT [PK_Lib_Core_Competencies] PRIMARY KEY ([coreCompetencyId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Departments] (
        [departmentId] int NOT NULL IDENTITY,
        [description] nvarchar(max) NULL,
        [is_active] bit NOT NULL,
        CONSTRAINT [PK_Lib_Departments] PRIMARY KEY ([departmentId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Job_Categories] (
        [jobCategoryId] int NOT NULL IDENTITY,
        [description] nvarchar(max) NULL,
        [is_active] bit NOT NULL,
        CONSTRAINT [PK_Lib_Job_Categories] PRIMARY KEY ([jobCategoryId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Occupational_Group_Codes] (
        [occupational_grp_code] nvarchar(10) NOT NULL,
        [description] nvarchar(max) NULL,
        [is_active] bit NOT NULL,
        CONSTRAINT [PK_Lib_Occupational_Group_Codes] PRIMARY KEY ([occupational_grp_code])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Occupational_Service_Codes] (
        [occupational_serv_code] nvarchar(10) NOT NULL,
        [description] nvarchar(500) NULL,
        [is_active] bit NOT NULL,
        CONSTRAINT [PK_Lib_Occupational_Service_Codes] PRIMARY KEY ([occupational_serv_code])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Provinces] (
        [prov_code] nvarchar(450) NOT NULL,
        [rowid] int NOT NULL IDENTITY,
        [region_code] nvarchar(max) NULL,
        [prov_name] nvarchar(max) NULL,
        [sortOrder] int NULL,
        CONSTRAINT [PK_Lib_Provinces] PRIMARY KEY ([prov_code])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Regions] (
        [region_code] nvarchar(450) NOT NULL,
        [rowid] int NOT NULL IDENTITY,
        [region_name] nvarchar(max) NULL,
        [sortOrder] int NULL,
        CONSTRAINT [PK_Lib_Regions] PRIMARY KEY ([region_code])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Request_Types] (
        [requestTypeId] int NOT NULL IDENTITY,
        [description] nvarchar(max) NULL,
        [is_active] bit NOT NULL,
        CONSTRAINT [PK_Lib_Request_Types] PRIMARY KEY ([requestTypeId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_User_Levels] (
        [userLevelId] int NOT NULL IDENTITY,
        [description] nvarchar(max) NULL,
        [is_active] bit NOT NULL,
        CONSTRAINT [PK_Lib_User_Levels] PRIMARY KEY ([userLevelId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [PersonDetails] (
        [personId] uniqueidentifier NOT NULL,
        [userId] uniqueidentifier NOT NULL,
        [firstName] nvarchar(max) NULL,
        [middleName] nvarchar(max) NULL,
        [lastName] nvarchar(max) NULL,
        [extName] nvarchar(max) NULL,
        [sex] int NOT NULL,
        [birthDate] datetime2 NOT NULL,
        [placeOfBirth] nvarchar(max) NULL,
        [civil_status_id] int NOT NULL,
        [citizenship_id] int NOT NULL,
        [blood_type_id] nvarchar(max) NULL,
        [height] nvarchar(max) NULL,
        [weight] nvarchar(max) NULL,
        [gsis] nvarchar(max) NULL,
        [philHealth] nvarchar(max) NULL,
        [sss] nvarchar(max) NULL,
        [pagIbig] nvarchar(max) NULL,
        [tin] nvarchar(max) NULL,
        [region_code] nvarchar(max) NULL,
        [prov_code] nvarchar(max) NULL,
        [city_code] nvarchar(max) NULL,
        [brgy_code] nvarchar(max) NULL,
        [purok] nvarchar(max) NULL,
        [zipCode] nvarchar(max) NULL,
        [telNo] nvarchar(max) NULL,
        [mobileNo] nvarchar(max) NULL,
        [email] nvarchar(max) NULL,
        [deleted_by] nvarchar(max) NULL,
        [deleted_date] datetime2 NULL,
        [is_deleted] bit NOT NULL,
        CONSTRAINT [PK_PersonDetails] PRIMARY KEY ([personId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Users] (
        [userId] uniqueidentifier NOT NULL,
        [userName] nvarchar(max) NULL,
        [salt] nvarchar(max) NULL,
        [hash_code] nvarchar(max) NULL,
        [deleted_by] nvarchar(max) NULL,
        [deleted_date] datetime2 NULL,
        [is_deleted] bit NOT NULL,
        [user_level] int NOT NULL,
        CONSTRAINT [PK_Users] PRIMARY KEY ([userId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [LDNAResults] (
        [ldnaResultId] uniqueidentifier NOT NULL,
        [coreCompetencyId] int NOT NULL,
        [competencyId] int NOT NULL,
        [permanent] int NOT NULL,
        [contractual] int NOT NULL,
        [LDNADetailsldnaId] uniqueidentifier NULL,
        CONSTRAINT [PK_LDNAResults] PRIMARY KEY ([ldnaResultId]),
        CONSTRAINT [FK_LDNAResults_LDNADetails_LDNADetailsldnaId] FOREIGN KEY ([LDNADetailsldnaId]) REFERENCES [LDNADetails] ([ldnaId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [Lib_Competency_Categories] (
        [competencyId] int NOT NULL IDENTITY,
        [description] nvarchar(max) NULL,
        [is_active] bit NOT NULL,
        [lib_core_competencycoreCompetencyId] int NULL,
        CONSTRAINT [PK_Lib_Competency_Categories] PRIMARY KEY ([competencyId]),
        CONSTRAINT [FK_Lib_Competency_Categories_Lib_Core_Competencies_lib_core_competencycoreCompetencyId] FOREIGN KEY ([lib_core_competencycoreCompetencyId]) REFERENCES [Lib_Core_Competencies] ([coreCompetencyId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [PersonEducations] (
        [personEducationId] uniqueidentifier NOT NULL,
        [nameOfSchool] nvarchar(max) NULL,
        [schoolLevelId] int NOT NULL,
        [yearGraduated] nvarchar(max) NULL,
        [startDate] datetime2 NOT NULL,
        [endDate] datetime2 NOT NULL,
        [degreeCourse] nvarchar(max) NULL,
        [highestAttaind] nvarchar(max) NULL,
        [scholarshipAwardHonor] nvarchar(max) NULL,
        [deleted_by] nvarchar(max) NULL,
        [deleted_date] datetime2 NULL,
        [is_deleted] bit NOT NULL,
        [PersonDetailpersonId] uniqueidentifier NULL,
        CONSTRAINT [PK_PersonEducations] PRIMARY KEY ([personEducationId]),
        CONSTRAINT [FK_PersonEducations_PersonDetails_PersonDetailpersonId] FOREIGN KEY ([PersonDetailpersonId]) REFERENCES [PersonDetails] ([personId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [PersonEligibilities] (
        [personEligibilityId] uniqueidentifier NOT NULL,
        [eligibilityTitle] nvarchar(max) NULL,
        [rating] int NOT NULL,
        [dateOfExamination] datetime2 NOT NULL,
        [placeOfExamination] nvarchar(max) NULL,
        [licenseNumber] nvarchar(max) NULL,
        [licensceReleaseDate] datetime2 NOT NULL,
        [deleted_by] nvarchar(max) NULL,
        [deleted_date] datetime2 NULL,
        [is_deleted] bit NOT NULL,
        [PersonDetailpersonId] uniqueidentifier NULL,
        CONSTRAINT [PK_PersonEligibilities] PRIMARY KEY ([personEligibilityId]),
        CONSTRAINT [FK_PersonEligibilities_PersonDetails_PersonDetailpersonId] FOREIGN KEY ([PersonDetailpersonId]) REFERENCES [PersonDetails] ([personId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [PersonFamilies] (
        [personFamilyId] uniqueidentifier NOT NULL,
        [firstName] nvarchar(max) NULL,
        [middleName] nvarchar(max) NULL,
        [lastName] nvarchar(max) NULL,
        [extName] nvarchar(max) NULL,
        [birthDate] datetime2 NOT NULL,
        [occupation] nvarchar(max) NULL,
        [employer] nvarchar(max) NULL,
        [businessAddress] nvarchar(max) NULL,
        [telNo] nvarchar(max) NULL,
        [relationship] int NOT NULL,
        [deleted_by] nvarchar(max) NULL,
        [deleted_date] datetime2 NULL,
        [is_deleted] bit NOT NULL,
        [PersonDetailpersonId] uniqueidentifier NULL,
        CONSTRAINT [PK_PersonFamilies] PRIMARY KEY ([personFamilyId]),
        CONSTRAINT [FK_PersonFamilies_PersonDetails_PersonDetailpersonId] FOREIGN KEY ([PersonDetailpersonId]) REFERENCES [PersonDetails] ([personId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [PersonTrainings] (
        [personTrainingId] uniqueidentifier NOT NULL,
        [personId] uniqueidentifier NOT NULL,
        [seminarTitle] nvarchar(max) NULL,
        [dateFrom] datetime2 NOT NULL,
        [dateTo] datetime2 NOT NULL,
        [numHours] int NOT NULL,
        [conductedBy] nvarchar(max) NULL,
        [deleted_by] nvarchar(max) NULL,
        [deleted_date] datetime2 NULL,
        [is_deleted] bit NOT NULL,
        [PersonDetailpersonId] uniqueidentifier NULL,
        CONSTRAINT [PK_PersonTrainings] PRIMARY KEY ([personTrainingId]),
        CONSTRAINT [FK_PersonTrainings_PersonDetails_PersonDetailpersonId] FOREIGN KEY ([PersonDetailpersonId]) REFERENCES [PersonDetails] ([personId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [PersonWorkExperiences] (
        [personWorkExperienceId] uniqueidentifier NOT NULL,
        [positionTitle] nvarchar(max) NULL,
        [companyName] nvarchar(max) NULL,
        [startDate] datetime2 NOT NULL,
        [endDate] datetime2 NULL,
        [monthlySalary] decimal(18,2) NOT NULL,
        [salaryGrade] int NOT NULL,
        [salaryStep] int NOT NULL,
        [appointmentStatusId] int NOT NULL,
        [isGovt] bit NOT NULL,
        [deleted_by] nvarchar(max) NULL,
        [deleted_date] datetime2 NULL,
        [is_deleted] bit NOT NULL,
        [PersonDetailpersonId] uniqueidentifier NULL,
        CONSTRAINT [PK_PersonWorkExperiences] PRIMARY KEY ([personWorkExperienceId]),
        CONSTRAINT [FK_PersonWorkExperiences_PersonDetails_PersonDetailpersonId] FOREIGN KEY ([PersonDetailpersonId]) REFERENCES [PersonDetails] ([personId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [WorkplaceAppicationPlans] (
        [wapId] uniqueidentifier NOT NULL,
        [title] nvarchar(max) NULL,
        [provider] nvarchar(max) NULL,
        [date_conduct] datetime2 NULL,
        [learningOutcome] nvarchar(max) NULL,
        [alignment] nvarchar(max) NULL,
        [PersonDetailspersonId] uniqueidentifier NULL,
        [startDate] datetime2 NULL,
        [endDate] datetime2 NULL,
        [objective] nvarchar(max) NULL,
        [output] nvarchar(max) NULL,
        CONSTRAINT [PK_WorkplaceAppicationPlans] PRIMARY KEY ([wapId]),
        CONSTRAINT [FK_WorkplaceAppicationPlans_PersonDetails_PersonDetailspersonId] FOREIGN KEY ([PersonDetailspersonId]) REFERENCES [PersonDetails] ([personId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE TABLE [ApplicationPlanAndAccomplishments] (
        [apaId] uniqueidentifier NOT NULL,
        [targetDate] datetime2 NULL,
        [milestone] int NOT NULL,
        [whatNeedsToBeDone] nvarchar(max) NULL,
        [meansOfVerification] nvarchar(max) NULL,
        [dateAssessed] datetime2 NULL,
        [progress] int NOT NULL,
        [whatWasDone] nvarchar(max) NULL,
        [whatWasNotDone] nvarchar(max) NULL,
        [ReasonForNonAccomplish] nvarchar(max) NULL,
        [catchUpActivities] nvarchar(max) NULL,
        [WorkplaceAppicationPlanwapId] uniqueidentifier NULL,
        CONSTRAINT [PK_ApplicationPlanAndAccomplishments] PRIMARY KEY ([apaId]),
        CONSTRAINT [FK_ApplicationPlanAndAccomplishments_WorkplaceAppicationPlans_WorkplaceAppicationPlanwapId] FOREIGN KEY ([WorkplaceAppicationPlanwapId]) REFERENCES [WorkplaceAppicationPlans] ([wapId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE INDEX [IX_ApplicationPlanAndAccomplishments_WorkplaceAppicationPlanwapId] ON [ApplicationPlanAndAccomplishments] ([WorkplaceAppicationPlanwapId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE INDEX [IX_LDNAResults_LDNADetailsldnaId] ON [LDNAResults] ([LDNADetailsldnaId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE INDEX [IX_Lib_Competency_Categories_lib_core_competencycoreCompetencyId] ON [Lib_Competency_Categories] ([lib_core_competencycoreCompetencyId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE INDEX [IX_PersonEducations_PersonDetailpersonId] ON [PersonEducations] ([PersonDetailpersonId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE INDEX [IX_PersonEligibilities_PersonDetailpersonId] ON [PersonEligibilities] ([PersonDetailpersonId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE INDEX [IX_PersonFamilies_PersonDetailpersonId] ON [PersonFamilies] ([PersonDetailpersonId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE INDEX [IX_PersonTrainings_PersonDetailpersonId] ON [PersonTrainings] ([PersonDetailpersonId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE INDEX [IX_PersonWorkExperiences_PersonDetailpersonId] ON [PersonWorkExperiences] ([PersonDetailpersonId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    CREATE INDEX [IX_WorkplaceAppicationPlans_PersonDetailspersonId] ON [WorkplaceAppicationPlans] ([PersonDetailspersonId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20211014135344_Cloud_origin')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20211014135344_Cloud_origin', N'5.0.2');
END;
GO

COMMIT;
GO

