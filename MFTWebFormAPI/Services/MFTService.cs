using AutoMapper;
using MFTWebFormAPI.Domain;
using MFTWebFormAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebFormAPI.Services {
    public class MFTService {
        private IRepository _repo;
        public MFTService(IRepository repo) {
            _repo = repo;
        }
        //Terms and related
        public List<TermDTO> ListTerms() {
            var termDto = new List<TermDTO>();
            var terms = _repo.Query<Term>().ToList();

            foreach (var term in terms) {
                termDto.Add(Mapper.Map<TermDTO>(term));
            }

            return termDto;
        }

        public void AddTerm(TermDTO term) {
            Term newTerm = Mapper.Map<Term>(term);
            _repo.Add<Term>(newTerm);
            _repo.SaveChanges();
        }

        //MFT new form section
        public Array GetDropDowns() {
            object[] dropDowns = {
               new {Name = "Events", Model = "Events", Data = _repo.Query<Event>().ToList() },
               new {Name = "Observable Data", Model = "ObservableData", Data = _repo.Query<ObservableData>().ToList() },
               new {Name = "Location", Model = "Group", Data = _repo.Query<Group>().ToList() },
               new {Name = "Supervisor", Model = "Supervisor",Data = _repo.Query<Supervisor>().ToList() },
            };

            return dropDowns;
        }

        public void AddMFTForm(MFTFormSubmissionDTO mftForm) {
            MFTFormSubmission newForm = Mapper.Map<MFTFormSubmission>(mftForm);
            _repo.Add<MFTFormSubmission>(newForm);
            _repo.SaveChanges();
        }
    };
};