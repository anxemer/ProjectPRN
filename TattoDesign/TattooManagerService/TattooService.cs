﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TattooManageRepository;
using TattooManagerObject.Models;

namespace TattooManagerService
{
    
    public class TattooService : ITattoService
    {
        private ITattooImageRepository imageRepository;
        public TattooService()
        {
            imageRepository = new TattooRepository();
        }
        public List<TattooImg> GetAllTattoo()
        {
            return imageRepository.getAllTattoo();
        }

        public List<TattooImg> GetTattooByCateId(int cateid)
        {
            return imageRepository.getTattooByCateId(cateid);
        }

        public TattooImg GetTattooById(int id)
        {
            return imageRepository.getTattooById(id);
        }

        public List<TattooImg> GetTattooByName(string name)
        {
            return imageRepository.geTattooByName(name);
        }
        public void UpdateTattoo(TattooImg tattoo, int id)
        {
            imageRepository.UpdateTattoo(tattoo, id);
        }
        public void AddTatoo(TattooImg newtattoo)
        {
            imageRepository.AddTattoo(newtattoo);
        }

        public void DeleteTattoo(int id)
        {
            imageRepository.RemoveTattoo(id);


        }
        public List<CategoryTattoo> GetAllCate()
        {
            return imageRepository.GetAllCate();
        }


    }
}
