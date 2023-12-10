using ThomasianOrglist.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;
using static System.Net.WebRequestMethods;

namespace ThomasianOrglist.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<Department> Departments { get; set; }


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Department>().HasData(
       new Department { Id = DepartmentName.FacultyOfArtsAndLetters, Name = DepartmentName.FacultyOfArtsAndLetters.ToString() },
       new Department { Id = DepartmentName.CollegeOfCommerceAndBusinessAdministration, Name = DepartmentName.CollegeOfCommerceAndBusinessAdministration.ToString() },
       new Department { Id = DepartmentName.CollegeOfEducation, Name = DepartmentName.CollegeOfEducation.ToString() },
       new Department { Id = DepartmentName.AMVCollegeOfAccountancy, Name = DepartmentName.AMVCollegeOfAccountancy.ToString() },
       new Department { Id = DepartmentName.CollegeOfTourismAndHospitalityManagement, Name = DepartmentName.CollegeOfTourismAndHospitalityManagement.ToString() },
       new Department { Id = DepartmentName.CollegeOfArchitecture, Name = DepartmentName.CollegeOfArchitecture.ToString() },
       new Department { Id = DepartmentName.CollegeOfInformationAndComputingScience, Name = DepartmentName.CollegeOfInformationAndComputingScience.ToString() },
       new Department { Id = DepartmentName.CollegeOfFineArtsAndDesign, Name = DepartmentName.CollegeOfFineArtsAndDesign.ToString() },
       new Department { Id = DepartmentName.FacultyOfEngineering, Name = DepartmentName.FacultyOfEngineering.ToString() },
       new Department { Id = DepartmentName.CollegeOfNursing, Name = DepartmentName.CollegeOfNursing.ToString() },
       new Department { Id = DepartmentName.FacultyOfPharmacy, Name = DepartmentName.FacultyOfPharmacy.ToString() },
       new Department { Id = DepartmentName.FacultyOfMedicineAndSurgery, Name = DepartmentName.FacultyOfMedicineAndSurgery.ToString() },
       new Department { Id = DepartmentName.UniversityWideOrganizations, Name = DepartmentName.UniversityWideOrganizations.ToString() }
   );


            modelBuilder.Entity<Organization>().HasData(
            new Organization
            {
                org_id = 1,
                OrgName = "Artistang Artlets",
                emailAdd = "artistangartlets.ab@ust.edu.ph",
                //Password = "hatdog13!",
                photo_filename = "../assets/artistangartlets2.png",
                Vision = "aowdaowdbaw",
                Mission = "awubdauwbdub",
                UrlLink = "https://www.facebook.com/ArtistangArtletsUST",
                Details = "Artistang Artlets (AA), the Recognized Theater Guild of the Faculty of Arts and Letters of " +
               "the University of Santo Tomas has been active servants and promoters of art for the past 42 years. ",
                DepartmentId = DepartmentName.FacultyOfArtsAndLetters
            },
            new Organization
            {
                org_id = 2,
                OrgName = "Artlets Economic Society",
                emailAdd = "aes.ab@ust.edu.ph",
                // Password = "hatdog12!",

                photo_filename = "../assets/ustartlets.jpg",
                Vision = "aowdaowdbaw",
                Mission = "awubdauwbdub",
                UrlLink = "https://www.facebook.com/ust.aes1975",
                Details = "The Artlets Economics Society of the UST Faculty of Arts and Letters, ever persevering in its goals to provide empowered and inspired " +
                "Thomasian economists to the Philippine society, which was established by her forefathers in 1975, has continually maintained her legacy of dynamism, " +
                "intellect, and compassion in order to fully realize her vision of an enlightened Filipino nation for all.\r\n",
                DepartmentId = DepartmentName.FacultyOfArtsAndLetters
            },
            new Organization
            {
                org_id = 3,
                OrgName = "UST Journalism Society",
                emailAdd = "journsoc.ab@ust.edu.ph",
                //Password = "hatdog12!",
                photo_filename = "../assets/journalism.jpg",

                Vision = "aowdaowdbaw",
                Mission = "awubdauwbdub",
                UrlLink = "https://www.facebook.com/ustjrnsoc",
                Details = "The Artlets Economics Society of the UST Faculty of Arts and Letters, ever persevering in its goals to provide empowered and inspired " +
                "Thomasian economists to the Philippine society, which was established by her forefathers in 1975, has continually maintained her legacy of dynamism, " +
                "intellect, and compassion in order to fully realize her vision of an enlightened Filipino nation for all.\r\n",
                DepartmentId = DepartmentName.FacultyOfArtsAndLetters
            },
             new Organization
             {
                 org_id = 4,
                 OrgName = "Thomasian Junior Association for People Management (TJAPM)\r\n",
                 emailAdd = "tjapm.comm@ust.edu.ph",
                 //Password = "hatdog12!",
                 photo_filename = "../assets/thomasianJunior.jpg",

                 Vision = "aowdaowdbaw",
                 Mission = "awubdauwbdub",
                 UrlLink = "https://www.facebook.com/USTTJAPM",
                 Details = "The TJAPM is the official student organization of the Human Resource Development Management majors, under the Business Administration Department of the College of Commerce and Business Administration.",
                 DepartmentId = DepartmentName.CollegeOfCommerceAndBusinessAdministration
             },
             new Organization
             {
                 org_id = 5,
                 OrgName = "UST Community Achievers Association-Commerce Unit",
                 emailAdd = "comach.uso@ust.edu.ph",
                 //Password = "hatdog12!",
                 photo_filename = "../assets/commAchCom.jpg",

                 Vision = "aowdaowdbaw",
                 Mission = "awubdauwbdub",
                 UrlLink = "https://www.facebook.com/ustcomach.cba",
                 Details = "The TJAPM is the official student organization of the Human Resource Development Management majors, under the Business Administration Department of the College of Commerce and Business Administration.",
                 DepartmentId = DepartmentName.CollegeOfCommerceAndBusinessAdministration
             },
              new Organization
              {
                  org_id = 6,
                  OrgName = "UST Junior Marketing Association",
                  emailAdd = "jma.comm@ust.edu.ph",
                  //Password = "hatdog12!",
                  photo_filename = "../assets/juniormarketing.jpg",
                  Vision = "aowdaowdbaw",
                  Mission = "awubdauwbdub",
                  UrlLink = "https://www.facebook.com/ustjma",
                  Details = "The TJAPM is the official student organization of the Human Resource Development Management majors, under the Business Administration Department of the College of Commerce and Business Administration.",
                  DepartmentId = DepartmentName.CollegeOfCommerceAndBusinessAdministration
              },
              new Organization
              {
                  org_id = 7,
                  OrgName = "Guild of Thomasian Speducators",
                  emailAdd = "guts.educ@ust.edu.ph",
                  //Password = "hatdog12!",
                  photo_filename = "../assets/guts.png",
                  Vision = "aowdaowdbaw",
                  Mission = "awubdauwbdub",
                  UrlLink = "https://www.facebook.com/ustguts",
                  Details = "The TJAPM is the official student organization of the Human Resource Development Management majors, under the Business Administration Department of the College of Commerce and Business Administration.",
                  DepartmentId = DepartmentName.CollegeOfEducation
              },
              new Organization
              {
                  org_id = 8,
                  OrgName = "Philippine Association of Nutrition Omega Chapter",
                  emailAdd = "panomegachapter.educ@ust.edu.ph",
                  //Password = "hatdog12!",
                  photo_filename = "../assets/panoc.jpg",
                  Vision = "aowdaowdbaw",
                  Mission = "awubdauwbdub",
                  UrlLink = "https://www.facebook.com/USTPANOC",
                  Details = "The TJAPM is the official student organization of the Human Resource Development Management majors, under the Business Administration Department of the College of Commerce and Business Administration.",
                  DepartmentId = DepartmentName.CollegeOfEducation
              },
              new Organization
              {
                  org_id = 9,
                  OrgName = "Pedagogue League of Future Educators",
                  emailAdd = "Pedagogue.LFE@ust.edu.ph",
                  //Password = "hatdog12!",
                  photo_filename = "../assets/pedag.jpg",
                  Vision = "aowdaowdbaw",
                  Mission = "awubdauwbdub",
                  UrlLink = "https://www.facebook.com/COEPLFE",
                  Details = "The TJAPM is the official student organization of the Human Resource Development Management majors, under the Business Administration Department of the College of Commerce and Business Administration.",
                  DepartmentId = DepartmentName.CollegeOfEducation
              },
              new Organization
              {
                  org_id = 10,
                  OrgName = "Junior Philippine Institute of Accountants",
                  emailAdd = "ijason2002@ust.edu.ph",
                  //Password = "hatdog12!",
                  photo_filename = "../assets/jpia.jpg",
                  Vision = "aowdaowdbaw",
                  Mission = "awubdauwbdub",
                  UrlLink = "https://www.facebook.com/JPIA.UST",
                  Details = "The University of Santo Tomas – Junior Philippine Institute of Accountants (UST-JPIA) is the official academic organization of BS Accountancy students of the University of Santo Tomas. The organization exposes its members to various internal and external activities which contribute to their holistic development as future Certified Public Accountants. It also serves as the bridge between the National Federation of Junior Philippine Institute of Accountants, National Federation of Junior Philippine Institute of Accountants - National Capital Region Council, and the Philippine Institute of Certified Public Accountants.",
                  DepartmentId = DepartmentName.AMVCollegeOfAccountancy
              },
               new Organization
               {
                   org_id = 11,
                   OrgName = "UST Community Achievers Association - Accountancy Unit",
                   emailAdd = "jpia.acct@ust.edu.ph",
                   //Password = "hatdog12!",
                   photo_filename = "../assets/comach.jpg",
                   Vision = "aowdaowdbaw",
                   Mission = "awubdauwbdub",
                   UrlLink = "https://www.facebook.com/comach.uso",
                   Details = "UST COMACH - ACCT is a recognized local student organization of the UST-Alfredo M. Velayo College of Accountancy. In line with the goal of promoting academic excellence, interpersonal relationship, and professional development concurrently, we seek to create a positive environment for all our Achievers to grow both as future accounting professionals and as advocates. It is our belief that an AMVian Achiever is best embodied by a well-rounded individual who excels not just in their academic endeavors and career, but also makes tangible contributions towards causes they feel strongly about. ",
                   DepartmentId = DepartmentName.AMVCollegeOfAccountancy
               },
                new Organization
                {
                    org_id = 12,
                    OrgName = "Scarlet-Accountancy Unit",
                    emailAdd = "ijason2002@ust.edu.ph",
                    //Password = "hatdog12!",
                    photo_filename = "../assets/AccScar.png",
                    Vision = "aowdaowdbaw",
                    Mission = "awubdauwbdub",
                    UrlLink = "https://www.facebook.com/scarletaccountancy",
                    Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                    DepartmentId = DepartmentName.AMVCollegeOfAccountancy
                },
                new Organization
                {
                    org_id = 13,
                    OrgName = "Hotel and Restaurant Management Society",
                    emailAdd = "ustscarletcentral@gmail.com",
                    //Password = "hatdog12!",
                    photo_filename = "../assets/hrms.jpg",
                    Vision = "aowdaowdbaw",
                    Mission = "awubdauwbdub",
                    UrlLink = "https://www.facebook.com/usthrms1980",
                    Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                    DepartmentId = DepartmentName.CollegeOfTourismAndHospitalityManagement
                },
                new Organization
                {
                    org_id = 14,
                    OrgName = "Intenzyc",
                    emailAdd = "ijason2002@ust.edu.ph",
                    //Password = "hatdog12!",
                    photo_filename = "../assets/intenz.png",
                    Vision = "aowdaowdbaw",
                    Mission = "awubdauwbdub",
                    UrlLink = "https://www.facebook.com/intenzyc",
                    Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                    DepartmentId = DepartmentName.CollegeOfTourismAndHospitalityManagement
                },
                new Organization
                {
                    org_id = 15,
                    OrgName = "Students Tourism Society",
                    emailAdd = "cthmintenzyc@gmail.com",
                    //Password = "hatdog12!",
                    photo_filename = "../assets/sts.jpg",
                    Vision = "aowdaowdbaw",
                    Mission = "awubdauwbdub",
                    UrlLink = "https://www.facebook.com/CTHMSTS",
                    Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                    DepartmentId = DepartmentName.CollegeOfTourismAndHospitalityManagement
                },
                new Organization
                {
                    org_id = 16,
                    OrgName = "Architecture Network (ARCHINET)",
                    emailAdd = "archinet.archi@ust.edu.ph",
                    //Password = "hatdog12!",
                    photo_filename = "../assets/archinet.jpg",
                    Vision = "aowdaowdbaw",
                    Mission = "awubdauwbdub",
                    UrlLink = "https://www.facebook.com/ustarchinet",
                    Details = "ARCHINET envisions itself as an interactive, virtuous, and service-oriented global community of architecture students, that would respect, cultivate and bring growth to their varied skills and abilities by holding an annual international jamboree and National Architecture Symposium by inviting students and professionals from all around the world to share, learn, and build an architectural network.",
                    DepartmentId = DepartmentName.CollegeOfArchitecture
                },
                new Organization
                {
                    org_id = 17,
                    OrgName = "Arkitrato: Architecture and Photography",
                    emailAdd = "arkitrato.ust@gmail.com",
                    //Password = "hatdog12!",
                    photo_filename = "../assets/arkitrato.jpg",
                    Vision = "aowdaowdbaw",
                    Mission = "awubdauwbdub",
                    UrlLink = "https://www.facebook.com/arkitrato.archi",
                    Details = "Arkitrato-UST is an innovative fusion of architecture and photography, seamlessly blending the artistic elements of these two disciplines. This project, presumably associated with the University of Santo Tomas (UST), explores the intersection of design and visual storytelling. Through a unique lens, Arkitrato-UST captures the essence of architectural marvels, translating the language of structures into captivating photographic narratives. The amalgamation of architecture and photography not only celebrates the aesthetic beauty of built environments but also delves into the symbiotic relationship between form and image, offering a fresh perspective on the intricate dance between the designed world and the lens that captures it.\r\n",
                    DepartmentId = DepartmentName.CollegeOfArchitecture
                },
                new Organization
                {
                    org_id = 18,
                    OrgName = "Heritage Conservation Society-UST Youth Chapter",
                    emailAdd = "hcs.archi@ust.edu.ph",
                    //Password = "hatdog12!",
                    photo_filename = "../assets/hcsyc.jpg",
                    Vision = "aowdaowdbaw",
                    Mission = "awubdauwbdub",
                    UrlLink = "https://www.facebook.com/hcs.ustarki",
                    Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                    DepartmentId = DepartmentName.CollegeOfArchitecture
                },
                 new Organization
                 {
                     org_id = 19,
                     OrgName = "CNAG-IICS",
                     emailAdd = "cnag.cics@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/CNAG.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/cnagics",
                     Details = "UST CNAG - CICS is the Official Cisco Organization for the College of Information & Computing Sciences.",
                     DepartmentId = DepartmentName.CollegeOfInformationAndComputingScience
                 },
                 new Organization
                 {
                     org_id = 20,
                     OrgName = "Thomasian Gaming Society",
                     emailAdd = "tgs.cics@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/tgs.png",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/ThomasianGamingSociety",
                     Details = "TGS is an Organization focused on the Gaming Community of the University of Santo Tomas",
                     DepartmentId = DepartmentName.CollegeOfInformationAndComputingScience
                 },
                 new Organization
                 {
                     org_id = 21,
                     OrgName = "Society of Information Technology Enthusiasts",
                     emailAdd = "site.cics@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/SITE.png",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/site.ust",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.CollegeOfInformationAndComputingScience
                 },
                 new Organization
                 {
                     org_id = 22,
                     OrgName = "Polymath Art Society",
                     emailAdd = "ijason2002@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/polymat.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/polymathartsocietyofficial",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.CollegeOfFineArtsAndDesign
                 },
                 new Organization
                 {
                     org_id = 23,
                     OrgName = "Touchpoint",
                     emailAdd = "ijason2002@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/touchpoint.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/USTCFADTouchpoint",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.CollegeOfFineArtsAndDesign
                 },
                 new Organization
                 {
                     org_id = 24,
                     OrgName = "Association of Civil Engineering Students",
                     emailAdd = "ijason2002@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/aces.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/USTACES",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.CollegeOfFineArtsAndDesign
                 },
                 new Organization
                 {
                     org_id = 25,
                     OrgName = "Network of Electronics Engineering Students",
                     emailAdd = "ijason2002@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/nees.png",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/USTNeces",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.FacultyOfEngineering
                 },
                 new Organization
                 {
                     org_id = 26,
                     OrgName = "UST IEEE Student Branch",
                     emailAdd = "ijason2002@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/IEEE.png",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/UST.IEEESB",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.FacultyOfEngineering
                 },
                 new Organization
                 {
                     org_id = 27,
                     OrgName = "UST Chorus of the Nightingales (Formerly UST Coro de Ruiseñores)",
                     emailAdd = "ijason2002@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/cinecon.png",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/ustnursingchorale",
                     Details = "The UST Coro de Ruisenores, formerly known as the Nursing Glee Club / Nursing Chorale, is the official chorale ensemble of the College of Nursing of the Pontifical and Royal University of Santo Tomas, The Catholic University of the Philippines. Under the artistic direction of its choirmaster, Mr. Emmanuel Garcia, its intention is to continue developing a varied and progressive repertoire of sacred and secular music. The group is composed of male and female students that are geared towards the path of the noble nursing profession but were all bound together by one common passion, amid the busy schedules and demanding academic loads the college has to offer, they still do not forget the theory that states that \"Nursing is an Art\" and that art is what that binds them together.",
                     DepartmentId = DepartmentName.CollegeOfNursing
                 },
                 new Organization
                 {
                     org_id = 28,
                     OrgName = "Medical Missions, Inc. - Nursing Group",
                     emailAdd = "ijason2002@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/medicalmission.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/USTMMING",
                     Details = "The Medical Missions Incorporated (MMI) is a charitable organization composed of doctors, nurses, nuns, priests and other paramedic personnel that render free social, medical, and surgical services to the indigent Filipinos in the urban and rural areas of the country.\r\n",
                     DepartmentId = DepartmentName.CollegeOfNursing
                 },
                 new Organization
                 {
                     org_id = 29,
                     OrgName = "UST Red Cross Youth Council - Nursing Unit",
                     emailAdd = "ijason2002@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/redcrossnurse.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/USTRCYCNU",
                     Details = "The Nursing Unit of the UST Red Cross Youth Council is a nonprofit socio-civic (student-led) organization that aims to educate and empower the youth in the spirit of service and social welfare through constructive trainings and effective leadership, provide volunteer opportunities and humanitarian experience, and working towards our own advocacies.",
                     DepartmentId = DepartmentName.CollegeOfNursing
                 },
                 new Organization
                 {
                     org_id = 30,
                     OrgName = "Junior Pharmacists' Association - Gamma Chapter",
                     emailAdd = "jpagamma.pharma@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/jppa.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/JPPhAGamma",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.FacultyOfPharmacy
                 },
                 new Organization
                 {
                     org_id = 31,
                     OrgName = "Medical Technology Society",
                     emailAdd = "official.ustomti@gmail.com",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/mts.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/OfficialOMTI",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.FacultyOfPharmacy
                 },
                 new Organization
                 {
                     org_id = 32,
                     OrgName = "UST Biochemistry Society",
                     emailAdd = "biochem-pharmacy@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/biochem.png",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/USTBiochem",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.FacultyOfPharmacy
                 },
                 new Organization
                 {
                     org_id = 33,
                     OrgName = "Asian Medical Students' Association",
                     emailAdd = "amsa.med@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/Amsa.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/AMSA.UST/",
                     Details = "AMSA-UST is a group of academically competent, socially responsible and globally competitive students of Medicine from the University of Santo Tomas, who serve not only as role models in the health profession, but also as influential leaders of society, upholding humanitarian ideals, medical ethics, & Christian values.",
                     DepartmentId = DepartmentName.FacultyOfMedicineAndSurgery
                 },
                 new Organization
                 {
                     org_id = 34,
                     OrgName = "Medical Missions, Inc. - Student Group",
                     emailAdd = "ijason2002@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/MMIs.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/groups/mmisg/?paipv=0&eav=AfY4ylxPjA1ak-fczvgkg3dTgyR2KZtY7rbOSXE2z50bk4kxtB9P6vV19MomnWtQoN4&_rdr",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.FacultyOfMedicineAndSurgery
                 },
                 new Organization
                 {
                     org_id = 35,
                     OrgName = "UST Medicine Glee Club",
                     emailAdd = "ustmedgleeclub@gmail.com",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/glee.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/ustmedicinegleeclub",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.FacultyOfMedicineAndSurgery
                 },
                 new Organization
                 {
                     org_id = 36,
                     OrgName = "Becarios de Santo Tomas",
                     emailAdd = "becarios.uso@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/becarios.png",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/ustbecarios",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.UniversityWideOrganizations
                 },
                 new Organization
                 {
                     org_id = 37,
                     OrgName = "Bosconian Thomasian Youth Movement",
                     emailAdd = "ustbtym@gmail.com",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/bosconian.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/buskongtomasino",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.UniversityWideOrganizations
                 },
                 new Organization
                 {
                     org_id = 38,
                     OrgName = "CFC Youth for Christ",
                     emailAdd = "hello@cfcyouthforchrist.net",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/CFC.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/cfcyouthforchrist",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.UniversityWideOrganizations
                 },
                 new Organization
                 {
                     org_id = 39,
                     OrgName = "CFC Youth for Family and Life",
                     emailAdd = "ijason2002@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/cfcyf.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/cfcyflperth",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.UniversityWideOrganizations
                 },
                 new Organization
                 {
                     org_id = 40,
                     OrgName = "Christ's Youth in Action",
                     emailAdd = "cya.correspondents@gmail.com",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/cya.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/cyaofficial",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.UniversityWideOrganizations
                 },
                 new Organization
                 {
                     org_id = 41,
                     OrgName = "Community Achievers Association",
                     emailAdd = "comach.uso@ust.edu.ph",
                     //Password = "hatdog12!",
                     photo_filename = "../assets/caa.jpg",
                     Vision = "aowdaowdbaw",
                     Mission = "awubdauwbdub",
                     UrlLink = "https://www.facebook.com/comach.uso",
                     Details = "SCARLET is the Filipino and Chinese Multi-Cultural Socio-Civic Student Organization of the Pontifical and Royal University of Santo Tomas.",
                     DepartmentId = DepartmentName.UniversityWideOrganizations
                 });

            base.OnModelCreating(modelBuilder);
        }

    }
}