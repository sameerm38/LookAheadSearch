using AutoMapper;
using LookAheadSearch.Web.Abstractions;
using LookAheadSearch.Web.Db;
using LookAheadSearch.Web.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LookAheadSearch.Web.Implementations
{
    public class ProductService : IProductService
    {
        private readonly LASDbContext dbContext;
        private readonly IMapper mapper;

        public ProductService(LASDbContext dbContext, IMapper mapper)
        {
            this.dbContext = dbContext;
            this.mapper = mapper;
            seeding();
        }

        private void seeding()
        {
            if(!dbContext.Products.Any())
            {
                dbContext.Products.Add(new Db.Product { Id = 1, Category = "General Medicine", Name = "8X Shampoo", Molecule = "Ciclopirox + Zinc pyrithione", HyperLink = "https://www.ciplamed.com/content/8x-shampoo" });
                dbContext.Products.Add(new Db.Product { Id = 2, Category = "General Medicine", Name = "ABAMUNE Tablets", Molecule = "Abacavir sulfate", HyperLink = "https://www.ciplamed.com/content/abamune-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 3, Category = "General Medicine", Name = "ABAMUNE-L Tablets", Molecule = "Abacavir sulfate + Lamivudine", HyperLink = "https://www.ciplamed.com/content/abamune-l-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 4, Category = "General Medicine", Name = "ACIVIR Cream", Molecule = "Aciclovir", HyperLink = "https://www.ciplamed.com/content/acivir-cream" });
                dbContext.Products.Add(new Db.Product { Id = 5, Category = "General Medicine", Name = "ACIVIR Eye Ointment", Molecule = "Acyclovir 3%", HyperLink = "https://www.ciplamed.com/content/acivir-eye-ointment" });
                dbContext.Products.Add(new Db.Product { Id = 6, Category = "General Medicine", Name = "ACIVIR DT Tablets", Molecule = "Aciclovir", HyperLink = "https://www.ciplamed.com/content/acivir-dt-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 7, Category = "General Medicine", Name = "ACIVIR I.V. Injection", Molecule = "Aciclovir", HyperLink = "https://www.ciplamed.com/content/acivir-iv-injection" });
                dbContext.Products.Add(new Db.Product { Id = 8, Category = "General Medicine", Name = "ACNEDAP Gel", Molecule = "Dapsone", HyperLink = "https://www.ciplamed.com/content/acnedap-gel" });
                dbContext.Products.Add(new Db.Product { Id = 9, Category = "General Medicine", Name = "Actemraо Injection", Molecule = "Tocilizumab", HyperLink = "https://www.ciplamed.com/content/actemra-injection" });
                dbContext.Products.Add(new Db.Product { Id = 10, Category = "General Medicine", Name = "ACTIPEEL Gel", Molecule = "Lactic acid 82%", HyperLink = "https://www.ciplamed.com/content/actipeel-gel" });
                dbContext.Products.Add(new Db.Product { Id = 11, Category = "General Medicine", Name = "ACTORISE Injection", Molecule = "Darbepoetin Alfa", HyperLink = "https://www.ciplamed.com/content/actorise-injection" });
                dbContext.Products.Add(new Db.Product { Id = 12, Category = "General Medicine", Name = "ADD TEARS Eye Drops", Molecule = "Sodium carboxymethyl cellulose 0.5%", HyperLink = "https://www.ciplamed.com/content/add-tears-eye-drops" });
                dbContext.Products.Add(new Db.Product { Id = 13, Category = "General Medicine", Name = "ADGAIN Capsules", Molecule = "Nutritional hair supplement", HyperLink = "https://www.ciplamed.com/content/adgain-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 14, Category = "General Medicine", Name = "ADVENT I.V. Injection", Molecule = "Amoxycillin sodium + Clavulanic acid", HyperLink = "https://www.ciplamed.com/content/advent-iv-injection" });
                dbContext.Products.Add(new Db.Product { Id = 15, Category = "General Medicine", Name = "AEROCORT Inhaler", Molecule = "Beclomethasone dipropionate + Levosalbutamol", HyperLink = "https://www.ciplamed.com/content/aerocort-inhaler" });
                dbContext.Products.Add(new Db.Product { Id = 16, Category = "General Medicine", Name = "AEROCORT Rotacaps", Molecule = "Beclomethasone dipropionate + Levosalbutamol", HyperLink = "https://www.ciplamed.com/content/aerocort-rotacaps" });
                dbContext.Products.Add(new Db.Product { Id = 17, Category = "General Medicine", Name = "AEROCORT FORTE Rotacaps", Molecule = "Beclomethasone dipropionate + Levosalbutamol", HyperLink = "https://www.ciplamed.com/content/aerocort-forte-rotacaps" });
                dbContext.Products.Add(new Db.Product { Id = 18, Category = "General Medicine", Name = "ALERID COLD Tablets", Molecule = "Cetirizine dihydrochloride + Phenylephrine hydrochloride + Paracetamol", HyperLink = "https://www.ciplamed.com/content/alerid-cold-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 19, Category = "General Medicine", Name = "ALERID D Tablets", Molecule = "Cetirizine hydrochloride + Phenylephrine hydrochloride", HyperLink = "https://www.ciplamed.com/content/alerid-d-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 20, Category = "General Medicine", Name = "ALFUSIN Tablets", Molecule = "Alfuzosin hydrochloride", HyperLink = "https://www.ciplamed.com/content/alfusin-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 21, Category = "General Medicine", Name = "ALFUSIN D Tablets", Molecule = "Alfuzosin hydrochloride + Dutasteride", HyperLink = "https://www.ciplamed.com/content/alfusin-d-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 22, Category = "General Medicine", Name = "AMANTREL Capsules", Molecule = "Amantadine hydrochloride", HyperLink = "https://www.ciplamed.com/content/amantrel-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 23, Category = "General Medicine", Name = "AMLOPRES Tablets", Molecule = "Amlodipine besilate", HyperLink = "https://www.ciplamed.com/content/amlopres-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 24, Category = "General Medicine", Name = "AMLOPRES AT Tablets", Molecule = "Amlodipine + Atenolol", HyperLink = "https://www.ciplamed.com/content/amlopres-at-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 25, Category = "General Medicine", Name = "AMLOPRES-TL Tablets", Molecule = "Telmisartan + Amlodipine", HyperLink = "https://www.ciplamed.com/content/amlopres-tl-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 26, Category = "General Medicine", Name = "AMLOPRES-L Tablets", Molecule = "Amlodipine + Lisinopril", HyperLink = "https://www.ciplamed.com/content/amlopres-l-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 27, Category = "General Medicine", Name = "ANTIFLU Capsules/ Suspension", Molecule = "Oseltamivir phosphate", HyperLink = "https://www.ciplamed.com/content/antiflu-capsules-suspension" });
                dbContext.Products.Add(new Db.Product { Id = 28, Category = "General Medicine", Name = "AQUA TEARS Ophthalmic Solution", Molecule = "Polyvinyl alcohol 1.4% + Polyvinyl povidone 0.6%", HyperLink = "https://www.ciplamed.com/content/aqua-tears-ophthalmic-solution" });
                dbContext.Products.Add(new Db.Product { Id = 29, Category = "General Medicine", Name = "ARMOTRAZ Tablets", Molecule = "Anastrozole", HyperLink = "https://www.ciplamed.com/content/armotraz-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 30, Category = "General Medicine", Name = "ASSURANS IV Injection", Molecule = "Sildenafil 10 mg/12.5 ml", HyperLink = "https://www.ciplamed.com/content/assurans-iv-injection" });
                dbContext.Products.Add(new Db.Product { Id = 31, Category = "General Medicine", Name = "ASSURANS Tablets", Molecule = "Sildenafil citrate", HyperLink = "https://www.ciplamed.com/content/assurans-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 32, Category = "General Medicine", Name = "ASTHALIN Inhaler", Molecule = "Salbutamol sulphate", HyperLink = "https://www.ciplamed.com/content/asthalin-inhaler" });
                dbContext.Products.Add(new Db.Product { Id = 33, Category = "General Medicine", Name = "ASTHALIN Respules", Molecule = "Salbutamol sulphate", HyperLink = "https://www.ciplamed.com/content/asthalin-respules" });
                dbContext.Products.Add(new Db.Product { Id = 34, Category = "General Medicine", Name = "ASTHALIN Rotacaps", Molecule = "Salbutamol sulphate", HyperLink = "https://www.ciplamed.com/content/asthalin-rotacaps" });
                dbContext.Products.Add(new Db.Product { Id = 35, Category = "General Medicine", Name = "ASTHALIN Respirator Solution", Molecule = "Salbutamol sulphate", HyperLink = "https://www.ciplamed.com/content/asthalin-respirator-solution" });
                dbContext.Products.Add(new Db.Product { Id = 36, Category = "General Medicine", Name = "ATORLIP Tablets", Molecule = "Atorvastatin calcium", HyperLink = "https://www.ciplamed.com/content/atorlip-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 37, Category = "General Medicine", Name = "ATORLIP ASP Capsules", Molecule = "Atorvastatin calcium + Aspirin", HyperLink = "https://www.ciplamed.com/content/atorlip-asp-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 38, Category = "General Medicine", Name = "ATORLIP CV Capsules", Molecule = "Atorvastatin calcium + Clopidogrel", HyperLink = "https://www.ciplamed.com/content/atorlip-cv-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 39, Category = "General Medicine", Name = "ATORLIP-F Tablets", Molecule = "Atorvastatin + Fenofibrate", HyperLink = "https://www.ciplamed.com/content/atorlip-f-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 40, Category = "General Medicine", Name = "AXALIN Expectorant", Molecule = "Ambroxol hydrochloride + Terbutaline sulphate + Guaiphenesin", HyperLink = "https://www.ciplamed.com/content/axalin-expectorant" });
                dbContext.Products.Add(new Db.Product { Id = 41, Category = "General Medicine", Name = "AZEE Tablets/DT/Dry Syrup", Molecule = "Azithromycin", HyperLink = "https://www.ciplamed.com/content/azee-tabletsdtdry-syrup" });
                dbContext.Products.Add(new Db.Product { Id = 42, Category = "General Medicine", Name = "AZEE I.V. Injection", Molecule = "Azithromycin", HyperLink = "https://www.ciplamed.com/content/azee-iv-injection" });
                dbContext.Products.Add(new Db.Product { Id = 43, Category = "General Medicine", Name = "AZIMAX Tablets", Molecule = "Azithromycin", HyperLink = "https://www.ciplamed.com/content/azimax-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 44, Category = "General Medicine", Name = "AZIMAX I.V. Injection", Molecule = "Azithromycin", HyperLink = "https://www.ciplamed.com/content/azimax-iv-injection" });
                dbContext.Products.Add(new Db.Product { Id = 45, Category = "General Medicine", Name = "AZMARDA Tablets", Molecule = "Sacubitril/Valsartan", HyperLink = "https://www.ciplamed.com/content/azmarda-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 46, Category = "General Medicine", Name = "BB24 Suspension", Molecule = "Calcium + Vitamin D3", HyperLink = "https://www.ciplamed.com/content/bb24-suspension" });
                dbContext.Products.Add(new Db.Product { Id = 47, Category = "General Medicine", Name = "BECLATE Inhaler", Molecule = "Beclomethasone dipropionate", HyperLink = "https://www.ciplamed.com/content/beclate-inhaler" });
                dbContext.Products.Add(new Db.Product { Id = 48, Category = "General Medicine", Name = "BECLATE Rotacaps", Molecule = "Beclomethasone dipropionate", HyperLink = "https://www.ciplamed.com/content/beclate-rotacaps" });
                dbContext.Products.Add(new Db.Product { Id = 49, Category = "General Medicine", Name = "BENDEX Tablets", Molecule = "Albendazole", HyperLink = "https://www.ciplamed.com/content/bendex-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 50, Category = "General Medicine", Name = "BENDEX Plus Tablets", Molecule = "Ivermectin + Albendazole", HyperLink = "https://www.ciplamed.com/content/bendex-plus-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 51, Category = "General Medicine", Name = "Biceltisо Injection", Molecule = "Trastuzumab", HyperLink = "https://www.ciplamed.com/content/biceltis-injection" });
                dbContext.Products.Add(new Db.Product { Id = 52, Category = "General Medicine", Name = "BILLARGIC Tablets", Molecule = "Bilastine", HyperLink = "https://www.ciplamed.com/content/billargic-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 53, Category = "General Medicine", Name = "BIOZORA Powder", Molecule = "Saccharomyces boulardii", HyperLink = "https://www.ciplamed.com/content/biozora-powder" });
                dbContext.Products.Add(new Db.Product { Id = 54, Category = "General Medicine", Name = "BIVASTAT Injection", Molecule = "Bivalirudin", HyperLink = "https://www.ciplamed.com/content/bivastat-injection" });
                dbContext.Products.Add(new Db.Product { Id = 55, Category = "General Medicine", Name = "BLEOCIP Injection", Molecule = "Bleomycin", HyperLink = "https://www.ciplamed.com/content/bleocip-injection" });
                dbContext.Products.Add(new Db.Product { Id = 56, Category = "General Medicine", Name = "BOSENTAS Tablets", Molecule = "Bosentan", HyperLink = "https://www.ciplamed.com/content/bosentas-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 57, Category = "General Medicine", Name = "BRIMOCOM Eye Drops", Molecule = "Brimonidine tartrate 0.2% + Timolol maleate 0.5%", HyperLink = "https://www.ciplamed.com/content/brimocom-eye-drops" });
                dbContext.Products.Add(new Db.Product { Id = 58, Category = "General Medicine", Name = "BRIMODIN Eye Drops", Molecule = "Brimonidine tartrate 0.2%", HyperLink = "https://www.ciplamed.com/content/brimodin-eye-drops" });
                dbContext.Products.Add(new Db.Product { Id = 59, Category = "General Medicine", Name = "BUDECORT Respules", Molecule = "Budesonide", HyperLink = "https://www.ciplamed.com/content/budecort-respules" });
                dbContext.Products.Add(new Db.Product { Id = 60, Category = "General Medicine", Name = "BUDECORT Rotacaps", Molecule = "Budesonide", HyperLink = "https://www.ciplamed.com/content/budecort-rotacaps" });
                dbContext.Products.Add(new Db.Product { Id = 61, Category = "General Medicine", Name = "BUDECORT Inhaler", Molecule = "Budesonide", HyperLink = "https://www.ciplamed.com/content/budecort-inhaler" });
                dbContext.Products.Add(new Db.Product { Id = 62, Category = "General Medicine", Name = "BUDENASE AQ Nasal Spray", Molecule = "Budesonide", HyperLink = "https://www.ciplamed.com/content/budenase-aq-nasal-spray" });
                dbContext.Products.Add(new Db.Product { Id = 63, Category = "General Medicine", Name = "CADRESS Ointment", Molecule = "Cadexomer iodine", HyperLink = "https://www.ciplamed.com/content/cadress-ointment" });
                dbContext.Products.Add(new Db.Product { Id = 64, Category = "General Medicine", Name = "CAL360 Tablets", Molecule = "Calcium citrate malate + Vitamin D3", HyperLink = "https://www.ciplamed.com/content/cal360-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 65, Category = "General Medicine", Name = "CALCINASE Nasal Spray", Molecule = "Calcitonin", HyperLink = "https://www.ciplamed.com/content/calcinase-nasal-spray" });
                dbContext.Products.Add(new Db.Product { Id = 66, Category = "General Medicine", Name = "CALUTIDE Tablets", Molecule = "Bicalutamide", HyperLink = "https://www.ciplamed.com/content/calutide-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 67, Category = "General Medicine", Name = "CALZEM Capsules", Molecule = "Calcitriol + Calcium carbonate + Zinc", HyperLink = "https://www.ciplamed.com/content/calzem-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 68, Category = "General Medicine", Name = "CAPEGARD 500 Tablets", Molecule = "Capecitabine", HyperLink = "https://www.ciplamed.com/content/capegard-500-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 69, Category = "General Medicine", Name = "CARLOC Tablets", Molecule = "Carvedilol", HyperLink = "https://www.ciplamed.com/content/carloc-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 70, Category = "General Medicine", Name = "CASPOGIN Injection", Molecule = "Caspofungin acetate", HyperLink = "https://www.ciplamed.com/content/caspogin-injection" });
                dbContext.Products.Add(new Db.Product { Id = 71, Category = "General Medicine", Name = "CASSOTIDE Tablets", Molecule = "Bicalutamide", HyperLink = "https://www.ciplamed.com/content/cassotide-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 72, Category = "General Medicine", Name = "CEFADUR Tablet", Molecule = "Cefadroxil", HyperLink = "https://www.ciplamed.com/content/cefadur-tablet" });
                dbContext.Products.Add(new Db.Product { Id = 73, Category = "General Medicine", Name = "CEFBACT T Injection", Molecule = "Ceftriaxone + Tazobactam", HyperLink = "https://www.ciplamed.com/content/cefbact-t-injection" });
                dbContext.Products.Add(new Db.Product { Id = 74, Category = "General Medicine", Name = "CEFOPROX Tablets/DT/Powder for Oral Suspension", Molecule = "Cefpodoxime proxetil", HyperLink = "https://www.ciplamed.com/content/cefoprox-tabletsdtpowder-for-oral-suspension" });
                dbContext.Products.Add(new Db.Product { Id = 75, Category = "General Medicine", Name = "CEFOPROX CV Tablets / Suspension", Molecule = "Cefpodoxime proxetil + Clavulanate potassium", HyperLink = "https://www.ciplamed.com/content/cefoprox-cv-tablets-suspension" });
                dbContext.Products.Add(new Db.Product { Id = 76, Category = "General Medicine", Name = "CEFOPROX XP Injection", Molecule = "Ceftriaxone + Tazobactam", HyperLink = "https://www.ciplamed.com/content/cefoprox-xp-injection" });
                dbContext.Products.Add(new Db.Product { Id = 77, Category = "General Medicine", Name = "CEFVAC-B Vaccine", Molecule = "Hepatitis B Vaccine (rDNA) I.P. (Genetically Engineered)", HyperLink = "https://www.ciplamed.com/content/cefvac-b-vaccine" });
                dbContext.Products.Add(new Db.Product { Id = 78, Category = "General Medicine", Name = "CELLMUNE Tablets", Molecule = "Mycophenolate mofetil 250 mg/500 mg", HyperLink = "https://www.ciplamed.com/content/cellmune-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 79, Category = "General Medicine", Name = "CEREBROCIP Injection", Molecule = "Cerebroprotein hydrolysate", HyperLink = "https://www.ciplamed.com/content/cerebrocip-injection" });
                dbContext.Products.Add(new Db.Product { Id = 80, Category = "General Medicine", Name = "CHESTON CS Syrup", Molecule = "Dextromethorphan hydrobromide + Chlorpheniramine maleate", HyperLink = "https://www.ciplamed.com/content/cheston-cs-syrup" });
                dbContext.Products.Add(new Db.Product { Id = 81, Category = "General Medicine", Name = "CHESTON Expectorant/DT", Molecule = "Bromhexine hydrochloride + Guaiphenesin + Chlorpheniramine", HyperLink = "https://www.ciplamed.com/content/cheston-expectorantdt" });
                dbContext.Products.Add(new Db.Product { Id = 82, Category = "General Medicine", Name = "CHESTON PLUS Syrup", Molecule = "Ambroxol hydrochloride + Terbutaline sulphate + Guaiphenesin", HyperLink = "https://www.ciplamed.com/content/cheston-plus-syrup" });
                dbContext.Products.Add(new Db.Product { Id = 83, Category = "General Medicine", Name = "CHYMOCIP Tablets", Molecule = "Trypsin + Chymotrypsin", HyperLink = "https://www.ciplamed.com/content/chymocip-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 84, Category = "General Medicine", Name = "CIP-ZOX Tablets", Molecule = "Diclofenac sodium + Chlorzoxazone + Paracetamol", HyperLink = "https://www.ciplamed.com/content/cip-zox-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 85, Category = "General Medicine", Name = "CIPEG Powder", Molecule = "Polyethylene glycol 3350", HyperLink = "https://www.ciplamed.com/content/cipeg-powder" });
                dbContext.Products.Add(new Db.Product { Id = 86, Category = "General Medicine", Name = "CIPGEST Tablets", Molecule = "Dienogest", HyperLink = "https://www.ciplamed.com/content/cipgest-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 87, Category = "General Medicine", Name = "CIPLACTIN Tablets", Molecule = "Cyproheptadine hydrochloride", HyperLink = "https://www.ciplamed.com/content/ciplactin-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 88, Category = "General Medicine", Name = "CIPLAR Tablets", Molecule = "Propranolol", HyperLink = "https://www.ciplamed.com/content/ciplar-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 89, Category = "General Medicine", Name = "CIPLAR-LA Tablets", Molecule = "Propranolol hydrochloride", HyperLink = "https://www.ciplamed.com/content/ciplar-la-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 90, Category = "General Medicine", Name = "CIPLORIC Tablets", Molecule = "Allopurinol", HyperLink = "https://www.ciplamed.com/content/ciploric-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 91, Category = "General Medicine", Name = "CIPLOX Tablets", Molecule = "Ciprofloxacin hydrochloride", HyperLink = "https://www.ciplamed.com/content/ciplox-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 92, Category = "General Medicine", Name = "CIPLOX-D Eye/Ear Drops", Molecule = "Ciprofloxacin + Dexamethasone sodium", HyperLink = "https://www.ciplamed.com/content/ciplox-d-eyeear-drops" });
                dbContext.Products.Add(new Db.Product { Id = 93, Category = "General Medicine", Name = "CIPLOX-OZ Tablets", Molecule = "Ciprofloxacin + Ornidazole", HyperLink = "https://www.ciplamed.com/content/ciplox-oz-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 94, Category = "General Medicine", Name = "CIPRUBICIN Injection", Molecule = "Epirubicin", HyperLink = "https://www.ciplamed.com/content/ciprubicin-injection" });
                dbContext.Products.Add(new Db.Product { Id = 95, Category = "General Medicine", Name = "CIPZEN D Tablets", Molecule = "Diclofenac sodium + Serratiopeptidase", HyperLink = "https://www.ciplamed.com/content/cipzen-d-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 96, Category = "General Medicine", Name = "CIPZEN D PLUS Tablets", Molecule = "Diclofenac potassium + Paracetamol + Serratiopeptidase", HyperLink = "https://www.ciplamed.com/content/cipzen-d-plus-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 97, Category = "General Medicine", Name = "CIZOREST Tablets", Molecule = "Amisulpride", HyperLink = "https://www.ciplamed.com/content/cizorest-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 98, Category = "General Medicine", Name = "CLAZE Gel", Molecule = "Arginine HCl 20% + Lactic acid 20% + Kojic acid 5% + Arbutin 2% + Citric acid 2%", HyperLink = "https://www.ciplamed.com/content/claze-gel" });
                dbContext.Products.Add(new Db.Product { Id = 99, Category = "General Medicine", Name = "CLOPIVAS Tablets", Molecule = "Clopidogrel bisulfate", HyperLink = "https://www.ciplamed.com/content/clopivas-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 100, Category = "General Medicine", Name = "CLOPIVAS-AP Tablets", Molecule = "Clopidogrel + Aspirin", HyperLink = "https://www.ciplamed.com/content/clopivas-ap-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 101, Category = "General Medicine", Name = "COGNOLIN Injection", Molecule = "Citicoline", HyperLink = "https://www.ciplamed.com/content/cognolin-injection" });
                dbContext.Products.Add(new Db.Product { Id = 102, Category = "General Medicine", Name = "COGNOLIN 500 Tablets", Molecule = "Citicoline", HyperLink = "https://www.ciplamed.com/content/cognolin-500-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 103, Category = "General Medicine", Name = "COGNOLIN P Tablets", Molecule = "Citicoline + Piracetam", HyperLink = "https://www.ciplamed.com/content/cognolin-p-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 104, Category = "General Medicine", Name = "CRANFIT Tablets", Molecule = "Cranberry + D-mannose", HyperLink = "https://www.ciplamed.com/content/cranfit-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 105, Category = "General Medicine", Name = "CRESAR Tablets", Molecule = "Telmisartan", HyperLink = "https://www.ciplamed.com/content/cresar-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 106, Category = "General Medicine", Name = "CRESAR AM Tablets", Molecule = "Telmisartan + Amlodipine", HyperLink = "https://www.ciplamed.com/content/cresar-am-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 107, Category = "General Medicine", Name = "CRESAR CT Tablets", Molecule = "Telmisartan + Chlorthalidone", HyperLink = "https://www.ciplamed.com/content/cresar-ct-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 108, Category = "General Medicine", Name = "CRESAR PLUS Tablets", Molecule = "Telmisartan + Amlodipine + Hydrochlorothiazide", HyperLink = "https://www.ciplamed.com/content/cresar-plus-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 109, Category = "General Medicine", Name = "CRESAR-H Tablets", Molecule = "Telmisartan + Hydrochlorothiazide", HyperLink = "https://www.ciplamed.com/content/cresar-h-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 110, Category = "General Medicine", Name = "CRIFOS 4 GM Injection", Molecule = "Fosfomycin sodium", HyperLink = "https://www.ciplamed.com/content/crifos-4-gm-injection" });
                dbContext.Products.Add(new Db.Product { Id = 111, Category = "General Medicine", Name = "CRISANTA Tablets", Molecule = "Drospirenone + Ethinylestradiol", HyperLink = "https://www.ciplamed.com/content/crisanta-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 112, Category = "General Medicine", Name = "CRISANTA LS Tablets", Molecule = "Drospirenone + Ethinylestradiol", HyperLink = "https://www.ciplamed.com/content/crisanta-ls-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 113, Category = "General Medicine", Name = "CRITPOSA Injection", Molecule = "Posaconazole", HyperLink = "https://www.ciplamed.com/content/critposa-injection" });
                dbContext.Products.Add(new Db.Product { Id = 114, Category = "General Medicine", Name = "CROMAL Eye Drops", Molecule = "Sodium cromoglycate 2%", HyperLink = "https://www.ciplamed.com/content/cromal-eye-drops" });
                dbContext.Products.Add(new Db.Product { Id = 115, Category = "General Medicine", Name = "CROMAL FORTE Eye Drops", Molecule = "Sodium cromoglycate 4%", HyperLink = "https://www.ciplamed.com/content/cromal-forte-eye-drops" });
                dbContext.Products.Add(new Db.Product { Id = 116, Category = "General Medicine", Name = "CUTISERA Serum", Molecule = "Growth factors + Cytokines", HyperLink = "https://www.ciplamed.com/content/cutisera-serum" });
                dbContext.Products.Add(new Db.Product { Id = 117, Category = "General Medicine", Name = "CYTOBLASTIN Injection", Molecule = "Vinblastine", HyperLink = "https://www.ciplamed.com/content/cytoblastin-injection" });
                dbContext.Products.Add(new Db.Product { Id = 118, Category = "General Medicine", Name = "CYTOCARB Injection", Molecule = "Carboplatin", HyperLink = "https://www.ciplamed.com/content/cytocarb-injection" });
                dbContext.Products.Add(new Db.Product { Id = 119, Category = "General Medicine", Name = "CYTOCRISTIN Injection", Molecule = "Vincristine", HyperLink = "https://www.ciplamed.com/content/cytocristin-injection" });
                dbContext.Products.Add(new Db.Product { Id = 120, Category = "General Medicine", Name = "CYTODROX Capsules", Molecule = "Hydroxyurea", HyperLink = "https://www.ciplamed.com/content/cytodrox-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 121, Category = "General Medicine", Name = "CYTOMID Tablets", Molecule = "Flutamide", HyperLink = "https://www.ciplamed.com/content/cytomid-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 122, Category = "General Medicine", Name = "CYTOPLATIN Injection", Molecule = "Cisplatin", HyperLink = "https://www.ciplamed.com/content/cytoplatin-injection" });
                dbContext.Products.Add(new Db.Product { Id = 123, Category = "General Medicine", Name = "CYTORX Tablets", Molecule = "Flucytosine", HyperLink = "https://www.ciplamed.com/content/cytorx-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 124, Category = "General Medicine", Name = "CYTOTAM Tablets", Molecule = "Tamoxifen citrate", HyperLink = "https://www.ciplamed.com/content/cytotam-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 125, Category = "General Medicine", Name = "D-SOL Granules/ Chewable Tablets/ Drops", Molecule = "Cholecalciferol", HyperLink = "https://www.ciplamed.com/content/d-sol-granules-chewable-tablets-drops" });
                dbContext.Products.Add(new Db.Product { Id = 126, Category = "General Medicine", Name = "D-VENLOR Tablets", Molecule = "Desvenlafaxine", HyperLink = "https://www.ciplamed.com/content/d-venlor-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 127, Category = "General Medicine", Name = "DABIPLA Capsules", Molecule = "Dabigatran etexilate mesylate", HyperLink = "https://www.ciplamed.com/content/dabipla-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 128, Category = "General Medicine", Name = "DALCINEX Injection", Molecule = "Clindamycin phosphate", HyperLink = "https://www.ciplamed.com/content/dalcinex-injection" });
                dbContext.Products.Add(new Db.Product { Id = 129, Category = "General Medicine", Name = "DANOGEN Capsules", Molecule = "Danazol", HyperLink = "https://www.ciplamed.com/content/danogen-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 130, Category = "General Medicine", Name = "DARUVIR 600 Tablets", Molecule = "Darunavir", HyperLink = "https://www.ciplamed.com/content/daruvir-600-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 131, Category = "General Medicine", Name = "DARUVIR 800 Tablets", Molecule = "Darunavir", HyperLink = "https://www.ciplamed.com/content/daruvir-800-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 132, Category = "General Medicine", Name = "DAUNOTEC Injection", Molecule = "Daunorubicin", HyperLink = "https://www.ciplamed.com/content/daunotec-injection" });
                dbContext.Products.Add(new Db.Product { Id = 133, Category = "General Medicine", Name = "DESIROX Tablets", Molecule = "Deferasirox", HyperLink = "https://www.ciplamed.com/content/desirox-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 134, Category = "General Medicine", Name = "DINEX EC Capsules", Molecule = "Didanosine", HyperLink = "https://www.ciplamed.com/content/dinex-ec-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 135, Category = "General Medicine", Name = "DIVAINE Injection", Molecule = "Minocycline", HyperLink = "https://www.ciplamed.com/content/divaine-injection" });
                dbContext.Products.Add(new Db.Product { Id = 136, Category = "General Medicine", Name = "DIVAINE Tablets", Molecule = "Minocycline", HyperLink = "https://www.ciplamed.com/content/divaine-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 137, Category = "General Medicine", Name = "DOCETAX Infusion", Molecule = "Docetaxel", HyperLink = "https://www.ciplamed.com/content/docetax-infusion" });
                dbContext.Products.Add(new Db.Product { Id = 138, Category = "General Medicine", Name = "DOCETAX", Molecule = "Docetaxel", HyperLink = "https://www.ciplamed.com/content/docetax" });
                dbContext.Products.Add(new Db.Product { Id = 139, Category = "General Medicine", Name = "DOMCET Tablet / Suspension", Molecule = "Domperidone maleate + Paracetamol", HyperLink = "https://www.ciplamed.com/content/domcet-tablet-suspension" });
                dbContext.Products.Add(new Db.Product { Id = 140, Category = "General Medicine", Name = "DONECEPT Tablets", Molecule = "Donepezil hydrochloride", HyperLink = "https://www.ciplamed.com/content/donecept-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 141, Category = "General Medicine", Name = "DONECEPT-M/ DONECEPT-M FORTE Tablets", Molecule = "Donepezil hydrochloride + Memantine hydrochloride", HyperLink = "https://www.ciplamed.com/content/donecept-m-donecept-m-forte-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 142, Category = "General Medicine", Name = "DORICRIT I.V. Injection", Molecule = "Doripenem", HyperLink = "https://www.ciplamed.com/content/doricrit-iv-injection" });
                dbContext.Products.Add(new Db.Product { Id = 143, Category = "General Medicine", Name = "DORZOX Eye Drops", Molecule = "Dorzolamide hydrochloride 2%", HyperLink = "https://www.ciplamed.com/content/dorzox-eye-drops" });
                dbContext.Products.Add(new Db.Product { Id = 144, Category = "General Medicine", Name = "DORZOX-T Eye Drops", Molecule = "Dorzolamide hydrochloride 2% + Timolol maleate 0.5%", HyperLink = "https://www.ciplamed.com/content/dorzox-t-eye-drops" });
                dbContext.Products.Add(new Db.Product { Id = 145, Category = "General Medicine", Name = "DUOFLO Combipack", Molecule = "Tamsulosin hydrochloride + Solifenacin succinate", HyperLink = "https://www.ciplamed.com/content/duoflo-combipack" });
                dbContext.Products.Add(new Db.Product { Id = 146, Category = "General Medicine", Name = "DUOLIN Inhaler", Molecule = "Levosalbutamol sulphate + Ipratropium bromide", HyperLink = "https://www.ciplamed.com/content/duolin-inhaler" });
                dbContext.Products.Add(new Db.Product { Id = 147, Category = "General Medicine", Name = "DUOLIN Respules", Molecule = "Levosalbutamol sulphate + Ipratropium bromide", HyperLink = "https://www.ciplamed.com/content/duolin-respules" });
                dbContext.Products.Add(new Db.Product { Id = 148, Category = "General Medicine", Name = "DUOLIN Rotacaps", Molecule = "Levosalbutamol sulphate + Ipratropium bromide", HyperLink = "https://www.ciplamed.com/content/duolin-rotacaps" });
                dbContext.Products.Add(new Db.Product { Id = 149, Category = "General Medicine", Name = "DUOLIN Forte Rotacaps", Molecule = "Levosalbutamol Sulphate + Ipratropium Bromide", HyperLink = "https://www.ciplamed.com/content/duolin-forte-rotacaps" });
                dbContext.Products.Add(new Db.Product { Id = 150, Category = "General Medicine", Name = "DUOLIN LD Respules", Molecule = "Levosalbutamol sulphate + Ipratropium bromide", HyperLink = "https://www.ciplamed.com/content/duolin-ld-respules" });
                dbContext.Products.Add(new Db.Product { Id = 151, Category = "General Medicine", Name = "DUONASE Nasal Spray", Molecule = "Azelastine hydrochloride + Fluticasone propionate", HyperLink = "https://www.ciplamed.com/content/duonase-nasal-spray" });
                dbContext.Products.Add(new Db.Product { Id = 152, Category = "General Medicine", Name = "DUOVA Inhaler", Molecule = "Tiotropium bromide monohydrate + Formoterol fumarate", HyperLink = "https://www.ciplamed.com/content/duova-inhaler" });
                dbContext.Products.Add(new Db.Product { Id = 153, Category = "General Medicine", Name = "DUOVA Rotacaps", Molecule = "Tiotropium bromide monohydrate + Formoterol fumarate dihydrate", HyperLink = "https://www.ciplamed.com/content/duova-rotacaps" });
                dbContext.Products.Add(new Db.Product { Id = 154, Category = "General Medicine", Name = "DUOVIR Tablets", Molecule = "Lamivudine + Zidovudine", HyperLink = "https://www.ciplamed.com/content/duovir-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 155, Category = "General Medicine", Name = "DUOVIR-E Kit", Molecule = "Efavirenz + Zidovudine + Lamivudine", HyperLink = "https://www.ciplamed.com/content/duovir-e-kit" });
                dbContext.Products.Add(new Db.Product { Id = 156, Category = "General Medicine", Name = "DUOVIR-N Tablets", Molecule = "Lamivudine + Zidovudine + Nevirapine", HyperLink = "https://www.ciplamed.com/content/duovir-n-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 157, Category = "General Medicine", Name = "DUPROST Capsules", Molecule = "Dutasteride", HyperLink = "https://www.ciplamed.com/content/duprost-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 158, Category = "General Medicine", Name = "DYTOR Tablets / Injection", Molecule = "Torsemide", HyperLink = "https://www.ciplamed.com/content/dytor-tablets-injection" });
                dbContext.Products.Add(new Db.Product { Id = 159, Category = "General Medicine", Name = "DYTOR PLUS Tablets", Molecule = "Torsemide + Spironolactone", HyperLink = "https://www.ciplamed.com/content/dytor-plus-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 160, Category = "General Medicine", Name = "EFAVIR Capsules/Tablets", Molecule = "Efavirenz", HyperLink = "https://www.ciplamed.com/content/efavir-capsulestablets" });
                dbContext.Products.Add(new Db.Product { Id = 161, Category = "General Medicine", Name = "EMESET Injection", Molecule = "Ondansetron hydrochloride", HyperLink = "https://www.ciplamed.com/content/emeset-injection" });
                dbContext.Products.Add(new Db.Product { Id = 162, Category = "General Medicine", Name = "EMESET Tablets", Molecule = "Ondansetron hydrochloride", HyperLink = "https://www.ciplamed.com/content/emeset-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 163, Category = "General Medicine", Name = "ENCLEX Injection", Molecule = "Enoxaparin", HyperLink = "https://www.ciplamed.com/content/enclex-injection" });
                dbContext.Products.Add(new Db.Product { Id = 164, Category = "General Medicine", Name = "ENDOBLOC T Kit", Molecule = "Ambrisentan + Tadalafil", HyperLink = "https://www.ciplamed.com/content/endobloc-t-kit" });
                dbContext.Products.Add(new Db.Product { Id = 165, Category = "General Medicine", Name = "ENDOBLOC Tablets", Molecule = "Ambrisentan", HyperLink = "https://www.ciplamed.com/content/endobloc-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 166, Category = "General Medicine", Name = "ENDOGEST Capsules", Molecule = "Micronized Progesterone", HyperLink = "https://www.ciplamed.com/content/endogest-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 167, Category = "General Medicine", Name = "ENTAVIR Tablets", Molecule = "Entecavir", HyperLink = "https://www.ciplamed.com/content/entavir-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 168, Category = "General Medicine", Name = "ENTOFOAM Rectal Foam", Molecule = "Hydrocortisone acetate", HyperLink = "https://www.ciplamed.com/content/entofoam-rectal-foam" });
                dbContext.Products.Add(new Db.Product { Id = 169, Category = "General Medicine", Name = "ERLOCIP Tablets", Molecule = "Erlotinib", HyperLink = "https://www.ciplamed.com/content/erlocip-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 170, Category = "General Medicine", Name = "ESOMAC Tablets", Molecule = "Esomeprazole magnesium", HyperLink = "https://www.ciplamed.com/content/esomac-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 171, Category = "General Medicine", Name = "ESOMAC I.V. Injection", Molecule = "Esomeprazole sodium", HyperLink = "https://www.ciplamed.com/content/esomac-iv-injection" });
                dbContext.Products.Add(new Db.Product { Id = 172, Category = "General Medicine", Name = "ESOMAC-D Capsules", Molecule = "Esomeprazole magnesium + Domperidone", HyperLink = "https://www.ciplamed.com/content/esomac-d-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 173, Category = "General Medicine", Name = "ESOMAC-L Capsules", Molecule = "Esomeprazole magnesium + Levosulpiride", HyperLink = "https://www.ciplamed.com/content/esomac-l-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 174, Category = "General Medicine", Name = "EspogenTM", Molecule = "Recombinant Human Erythropoietin", HyperLink = "https://www.ciplamed.com/content/espogentm" });
                dbContext.Products.Add(new Db.Product { Id = 175, Category = "General Medicine", Name = "ESTOVA Tablets", Molecule = "Estradiol valerate", HyperLink = "https://www.ciplamed.com/content/estova-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 176, Category = "General Medicine", Name = "ETACEPT Injection", Molecule = "Etanercept", HyperLink = "https://www.ciplamed.com/content/etacept-injection" });
                dbContext.Products.Add(new Db.Product { Id = 177, Category = "General Medicine", Name = "ETOSID Injection", Molecule = "Etoposide", HyperLink = "https://www.ciplamed.com/content/etosid-injection" });
                dbContext.Products.Add(new Db.Product { Id = 178, Category = "General Medicine", Name = "EVERFRESH Hygiene Wash", Molecule = "Lactic acid, lily extract, etc.", HyperLink = "https://www.ciplamed.com/content/everfresh-hygiene-wash" });
                dbContext.Products.Add(new Db.Product { Id = 179, Category = "General Medicine", Name = "EXCELA Moisturiser", Molecule = "Myristyl malate phosphonic acid, glycerine etc.", HyperLink = "https://www.ciplamed.com/content/excela-moisturiser" });
                dbContext.Products.Add(new Db.Product { Id = 180, Category = "General Medicine", Name = "FAROBACT 200 Tablets", Molecule = "Faropenem", HyperLink = "https://www.ciplamed.com/content/farobact-200-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 181, Category = "General Medicine", Name = "FAROBACT 300 ER Tablets", Molecule = "Faropenem sodium", HyperLink = "https://www.ciplamed.com/content/farobact-300-er-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 182, Category = "General Medicine", Name = "FEBUCIP Tablets", Molecule = "Febuxostat", HyperLink = "https://www.ciplamed.com/content/febucip-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 183, Category = "General Medicine", Name = "FEMPRO Tablets", Molecule = "Letrozole", HyperLink = "https://www.ciplamed.com/content/fempro-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 184, Category = "General Medicine", Name = "FENOLIP 145 Tablets", Molecule = "Fenofibrate", HyperLink = "https://www.ciplamed.com/content/fenolip-145-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 185, Category = "General Medicine", Name = "FERTOLET Tablets", Molecule = "Letrozole", HyperLink = "https://www.ciplamed.com/content/fertolet-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 186, Category = "General Medicine", Name = "FERTOMID Tablets", Molecule = "Clomiphene citrate", HyperLink = "https://www.ciplamed.com/content/fertomid-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 187, Category = "General Medicine", Name = "FEVAGO Suspension/Drops", Molecule = "Paracetamol", HyperLink = "https://www.ciplamed.com/content/fevago-suspensiondrops" });
                dbContext.Products.Add(new Db.Product { Id = 188, Category = "General Medicine", Name = "FINCAR Tablets", Molecule = "Finasteride", HyperLink = "https://www.ciplamed.com/content/fincar-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 189, Category = "General Medicine", Name = "FINPECIA Tablets", Molecule = "Finasteride", HyperLink = "https://www.ciplamed.com/content/finpecia-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 190, Category = "General Medicine", Name = "FLAVOCIP Tablets", Molecule = "Flavoxate hydrochloride", HyperLink = "https://www.ciplamed.com/content/flavocip-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 191, Category = "General Medicine", Name = "Flogel Ultra Lubricant Eye Drops", Molecule = "Polyethylene glycol 400 0.4% + Propylene glycol 0.3%", HyperLink = "https://www.ciplamed.com/content/flogel-ultra-lubricant-eye-drops" });
                dbContext.Products.Add(new Db.Product { Id = 192, Category = "General Medicine", Name = "FLOGEL Eye Drops", Molecule = "Sodium carboxymethyl cellulose 1.0%", HyperLink = "https://www.ciplamed.com/content/flogel-eye-drops" });
                dbContext.Products.Add(new Db.Product { Id = 193, Category = "General Medicine", Name = "FLOHALE Inhaler", Molecule = "Fluticasone propionate", HyperLink = "https://www.ciplamed.com/content/flohale-inhaler" });
                dbContext.Products.Add(new Db.Product { Id = 194, Category = "General Medicine", Name = "FLOHALE Respules", Molecule = "Fluticasone propionate", HyperLink = "https://www.ciplamed.com/content/flohale-respules" });
                dbContext.Products.Add(new Db.Product { Id = 195, Category = "General Medicine", Name = "FLOMIST Aqueous Nasal Spray", Molecule = "Fluticasone propionate", HyperLink = "https://www.ciplamed.com/content/flomist-aqueous-nasal-spray" });
                dbContext.Products.Add(new Db.Product { Id = 196, Category = "General Medicine", Name = "FLOSOFT Eye Drops", Molecule = "Fluorometholone acetate 0.1%", HyperLink = "https://www.ciplamed.com/content/flosoft-eye-drops" });
                dbContext.Products.Add(new Db.Product { Id = 197, Category = "General Medicine", Name = "For-IC Capsules", Molecule = "Pentosan polysulphate sodium", HyperLink = "https://www.ciplamed.com/content/for-ic-capsules" });
                dbContext.Products.Add(new Db.Product { Id = 198, Category = "General Medicine", Name = "FORACORT Autohaler", Molecule = "Formoterol fumarate dihydrate + Budesonide", HyperLink = "https://www.ciplamed.com/content/foracort-autohaler" });
                dbContext.Products.Add(new Db.Product { Id = 199, Category = "General Medicine", Name = "FORACORT Inhaler", Molecule = "Formoterol fumarate dihydrate + Budesonide", HyperLink = "https://www.ciplamed.com/content/foracort-inhaler" });
                dbContext.Products.Add(new Db.Product { Id = 200, Category = "General Medicine", Name = "FORACORT Respules", Molecule = "Formoterol fumarate + Budesonide respirator", HyperLink = "https://www.ciplamed.com/content/foracort-respules" });
                dbContext.Products.Add(new Db.Product { Id = 201, Category = "General Medicine", Name = "FORACORT Rotacaps", Molecule = "Formoterol fumarate dihydrate + Budesonide", HyperLink = "https://www.ciplamed.com/content/foracort-rotacaps" });
                dbContext.Products.Add(new Db.Product { Id = 202, Category = "General Medicine", Name = "FORACORT FORTE Inhaler", Molecule = "Formoterol fumarate dihydrate + Budesonide", HyperLink = "https://www.ciplamed.com/content/foracort-forte-inhaler" });
                dbContext.Products.Add(new Db.Product { Id = 203, Category = "General Medicine", Name = "FORACORT FORTE Rotacaps", Molecule = "Formoterol fumarate dihydrate + Budesonide", HyperLink = "https://www.ciplamed.com/content/foracort-forte-rotacaps" });
                dbContext.Products.Add(new Db.Product { Id = 204, Category = "General Medicine", Name = "FORCAN Tablets", Molecule = "Fluconazole", HyperLink = "https://www.ciplamed.com/content/forcan-tablets" });
                dbContext.Products.Add(new Db.Product { Id = 205, Category = "General Medicine", Name = "FORCAN /FORCAN PLUS Injection", Molecule = "Fluconazole", HyperLink = "https://www.ciplamed.com/content/forcan-forcan-plus-injection" });
                dbContext.Products.Add(new Db.Product { Id = 206, Category = "General Medicine", Name = "FORPAR XP Injection", Molecule = "Cefepime + Tazobactam", HyperLink = "https://www.ciplamed.com/content/forpar-xp-injection" });
                dbContext.Products.Add(new Db.Product { Id = 207, Category = "General Medicine", Name = "FOSAPREPIT 150 Injection", Molecule = "Fosaprepitant dimeglumine", HyperLink = "https://www.ciplamed.com/content/fosaprepit-150-injection" });
                dbContext.Products.Add(new Db.Product { Id = 208, Category = "General Medicine", Name = "FOSIROL Powder", Molecule = "Fosfomycin trometamol", HyperLink = "https://www.ciplamed.com/content/fosirol-powder" });
                dbContext.Products.Add(new Db.Product { Id = 209, Category = "General Medicine", Name = "FULLFORM Rotacaps", Molecule = "Beclomethasone dipropionate + Formoterol fumarate", HyperLink = "https://www.ciplamed.com/content/fullform-rotacaps" });
                dbContext.Products.Add(new Db.Product { Id = 210, Category = "General Medicine", Name = "FURAMIST Nasal Spray", Molecule = "Fluticasone furoate", HyperLink = "https://www.ciplamed.com/content/furamist-nasal-spray" });
                dbContext.Products.Add(new Db.Product { Id = 211, Category = "General Medicine", Name = "FURAMIST AZ Nasal Spray", Molecule = "Fluticasone furoate + Azelastine hydrochloride", HyperLink = "https://www.ciplamed.com/content/furamist-az-nasal-spray" });
                dbContext.Products.Add(new Db.Product { Id = 212, Category = "General Medicine", Name = "Gatiquin Eye Drops", Molecule = "Gatifloxacin 0.3%", HyperLink = "https://www.ciplamed.com/content/gatiquin-eye-drops" });
                dbContext.Products.Add(new Db.Product { Id = 213, Category = "General Medicine", Name = "GATIQUIN HS Eye Drops", Molecule = "Gatifloxacin 0.5%", HyperLink = "https://www.ciplamed.com/content/gatiquin-hs-eye-drops" });
                dbContext.SaveChanges();
            }
        }

        public async Task<(bool IsSuccess, IEnumerable<Models.Product> Products, string ErrorMessage)> SearchByName(string NameString)
        {
            try
            {
                var products = await dbContext.Products.Where(p => p.Name.ToLower().StartsWith(NameString.ToLower())).ToListAsync();
                if(products!=null && products.Any())
                {
                    var result = mapper.Map<IEnumerable<Db.Product>, IEnumerable<Models.Product>>(products);
                    return (true, result, null);
                }
                return (false, null, "Not Found");
            }
            catch (Exception ex)
            {

                return (false, null, ex.Message);
            }
        }
    }
}
