package com.example.bootcamp.sales.product;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@CrossOrigin
@RestController
@RequestMapping("api/products")
public class ProductController {

	@Autowired
	private ProductRepository productRepo;
	
	@GetMapping
	public ResponseEntity<Iterable<Product>> GetProduct(){
		var products =productRepo.findAll();
		return new ResponseEntity<Iterable<Product>>(products, HttpStatus.OK);
	}
	
	@GetMapping("{id}")
	public ResponseEntity<Product> GetProductById(@PathVariable int id){
	var product = productRepo.findById(id);
	if(product.isEmpty()) {
		return new ResponseEntity<>(HttpStatus.NOT_FOUND);
	}
		return new ResponseEntity<Product>(product.get(),HttpStatus.OK);
	}
	
	@PostMapping
	public ResponseEntity<Product> PostProduct(@RequestBody Product product){
		if (product == null || product.getId() != 0){
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}
		var p1 =productRepo.save(product);
		return new ResponseEntity<Product>(p1,HttpStatus.CREATED);
	}
	
	@PutMapping("{id}")
	public ResponseEntity<Product> PutProduct(@RequestBody Product product, @PathVariable int id){
		if(product == null || product.getId()==0) {
			return new ResponseEntity<>(HttpStatus.BAD_REQUEST);
		}
		var p1 = productRepo.findById(id);
		if(p1.isEmpty()) {
			return new ResponseEntity<>(HttpStatus.NOT_FOUND);
		}
		productRepo.save(product);
		return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	}
	@DeleteMapping("{id}")
	public ResponseEntity<Product> DeleteProduct(@PathVariable int id){
		var product = productRepo.findById(id);
	if(product.isEmpty()) {
		return new ResponseEntity<>(HttpStatus.NOT_FOUND);
	}
	productRepo.delete(product.get());
	return new ResponseEntity<>(HttpStatus.NO_CONTENT);
	
	}
	
}
