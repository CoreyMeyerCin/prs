package com.example.bootcamp.sales.requestline;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.persistence.JoinColumn;
import javax.persistence.ManyToOne;
import com.example.bootcamp.sales.product.Product;
import com.example.bootcamp.sales.request.Request;
import com.fasterxml.jackson.annotation.JsonBackReference;

 @Entity
 
public class Requestline {
		@Id	
		@GeneratedValue(strategy=GenerationType.IDENTITY)
		 public int id;
	     private int quantity;

	    
		@JsonBackReference
	    @ManyToOne(optional=false)
	    @JoinColumn(name="requestId")
	     private Request request;
		
	    
		@ManyToOne(optional=false)
		@JoinColumn(name="productId")
		private Product product;
		////////////////////////////////////////////////////
		public Requestline() {}
		////////////////////////////////////////////////////
		
		
		
		
		public int getId() {
			return id;
		}
		public void setId(int id) {
			this.id = id;
		}
		public int getQuantity() {
			return quantity;
		}
		public void setQuantity(int quantity) {
			this.quantity = quantity;
		}
		public Request getRequest() {
			return request;
		}
		public void setRequest(Request request) {
			this.request = request;
		}
		public Product getProduct() {
			return product;
		}
		public void setProduct(Product product) {
			this.product = product;
		}
		
		
		
	
}
