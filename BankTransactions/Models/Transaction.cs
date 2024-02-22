using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BankTransactions.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Column(TypeName ="nvarchar(12)")]
        [DisplayName("Account Number")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(12,ErrorMessage ="Maximum 12 characters only.")]
        public string AccountNumber { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Beneficiary Number")]
        [Required(ErrorMessage ="This field is required.")]
        public string BeneficiaryNumber { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Bank Name")]
        [Required(ErrorMessage = "This field is required.")]
        public string BankName { get; set; }
        [Column(TypeName = "nvarchar(12)")]
        [DisplayName("Swift Code")]
        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(11, ErrorMessage = "Maximum 11 characters only.")]
        public string SwiftCode {  get; set; }
        [Required(ErrorMessage = "This field is required.")]
        public string Ammount { get; set;}
        [DisplayFormat(DataFormatString ="{0:MMM-dd-yy}")]
        public DateTime Date {  get; set; }
    }
}
