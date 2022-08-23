using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;

using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OfferMan : IOfferService
    {
        IOffer ıoffer;
        public OfferMan(IOffer ıoffer)
        {
            this.ıoffer = ıoffer;
        }

        public Offer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Offer> GetListOffer(int id)
        {
            return ıoffer.GetListAll(x => x.ProductId==id);
        }
        public List<Offer> GetListOfferByUser(int id)
        {
            return null;//ıoffer.GetListAll(x => x.UserId == id);
        }

        public List<Offer> ListAll()
        {
            throw new NotImplementedException();
        }

       /* public void OfferAdd(Offer offer)
        {
            ıoffer.Insert(offer);
        }*/

        public void TAdd(Offer t)
        {
            ıoffer.Insert(t);
        }

        public void TDelete(Offer t)
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Offer t)
        {
            throw new NotImplementedException();
        }
    }
}
