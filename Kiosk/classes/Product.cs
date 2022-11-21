using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//상품 정보를 저장하는 클래스이다.
namespace Kiosk.classes
{
   public class Product
    {
        /*객체 속성*/
        
        //상품 이름
        private String name;
        //상품 가격
        private int price;
        //상품 개수
        //private int amount;

        //Product 클래스의 생성자 -> 객체를 생성할 때 객체를 초기화하는 함수이다.
        public Product(String name , int price ) {
            this.name = name;
            this.price = price;   
        }

        public String GetName() {
            return this.name;
        } 

        public int GetPrice() {
            return this.price;
        }


    }
}
