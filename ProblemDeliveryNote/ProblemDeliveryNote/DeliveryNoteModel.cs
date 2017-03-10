using System;
using System.Collections.Generic;

namespace ProblemDeliveryNote
{
    public class DeliveryNoteModel
    {
        public static int deliveryNoteID = 0;

        private PublisherModel publisher;
        private RecipientModel recipient;
        private List<ItemModel> items;

        public DeliveryNoteModel(PublisherModel publisher, RecipientModel recipient, List<ItemModel> items)
        {
            this.Publisher = publisher;
            this.Recipient = recipient;
            this.Items = items;
        }

        public string Date
        {
            get
            {
                return DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year + " г.";
            }
        }
        public PublisherModel Publisher { get; set; }
        public RecipientModel Recipient { get; set; }
        public List<ItemModel> Items { get; set; }
    }
}