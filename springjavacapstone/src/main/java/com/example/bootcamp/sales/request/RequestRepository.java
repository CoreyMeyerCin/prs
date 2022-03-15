package com.example.bootcamp.sales.request;

import java.util.Optional;

import org.springframework.data.repository.CrudRepository;

public interface RequestRepository extends CrudRepository<Request,Integer> {

	Optional <Request> findAllByUserId(int userId);
}
