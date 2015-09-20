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

        public List<TermDTO> ListTerms() {
            return new List<TermDTO>() {
                new TermDTO {Name = "Test" },
                new TermDTO {Name = "Test 2" },
                new TermDTO {Name = "Test 3" },
            };

            //var termDto = new List<TermDTO>();
            //var terms = _repo.Query<Term>().ToList();

            //foreach (var term in terms) {
            //    termDto.Add(Mapper.Map<TermDTO>(term));
            //}
            
            //return termDto;
        }
    }
}