using AutoMapper;
using MFTWebFormAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MFTWebFormAPI.Services {
    public class AutoMapperConfig {
        public static void RegisterMaps() {
            Mapper.CreateMap<EventDTO, Event>();
            Mapper.CreateMap<GroupDTO, Group>();
            Mapper.CreateMap<MFTFormSubmissionDTO, MFTFormSubmission>();
            Mapper.CreateMap<SupervisorDTO, Supervisor>();
            Mapper.CreateMap<ObservableDataDTO, ObservableData>();
            Mapper.CreateMap<TermDTO, Term>();

            Mapper.CreateMap<Event, EventDTO>();
            Mapper.CreateMap<Group, GroupDTO>();
            Mapper.CreateMap<MFTFormSubmission, MFTFormSubmissionDTO>();
            Mapper.CreateMap<Supervisor, SupervisorDTO>();
            Mapper.CreateMap<ObservableData, ObservableDataDTO>();
            Mapper.CreateMap<Term, TermDTO>();
        }
    }
}