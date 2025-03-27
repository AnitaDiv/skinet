import { Component, inject, OnInit } from '@angular/core';
import { OrderService } from '../../core/services/order.service';
import { Order } from '../../shared/models/order';
import { RouterLink } from '@angular/router';
import { CurrencyPipe, DatePipe } from '@angular/common';

@Component({
  selector: 'app-order',
  standalone: true,
  imports: [
    RouterLink,
    DatePipe,
    CurrencyPipe
  ],
  templateUrl: './order.component.html',
  styleUrl: './order.component.scss'
})
export class OrderComponent implements OnInit{
  private orderService = inject(OrderService);
  orders: Order[] = [];

  ngOnInit(): void {
    this.loadOrders();
  }

  loadOrders(orderStatus?: string): void {
    this.orderService.getOrdersForUser(orderStatus).subscribe({
      next: orders => this.orders = orders
    });
  }

  onFilterClick(orderStatus: string): void {
    this.loadOrders(orderStatus);
  }
}
