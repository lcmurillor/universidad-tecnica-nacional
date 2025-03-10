
import { IsDate, IsNotEmpty, MaxLength } from "class-validator";
import { Column, Entity, ManyToOne, OneToMany, PrimaryGeneratedColumn } from "typeorm";
import { business } from "./business";
import { order_line } from "./order_line";
import { payment_type } from "./payment_type";
import { user } from "./user";

@Entity()
export class order {
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(10)
    date: string;

    @Column() @IsNotEmpty() @MaxLength(2)
    order_state: string;

    @Column() @IsNotEmpty() @MaxLength(250)
    details: string;

    @Column() @IsNotEmpty() @MaxLength(1)
    state: string;

    @Column() @IsNotEmpty() @MaxLength(10) @IsDate()
    created_at: string;

    @Column() @IsNotEmpty() @MaxLength(10) @IsDate()
    updated_at: string;

    @ManyToOne(type => business, business => business.order)
    business: business;

    @ManyToOne(type => payment_type, payment_type => payment_type.order)
    payment_type: payment_type;

    @ManyToOne(type => user, user => user.order)
    user: user;

    @OneToMany(type => order_line, order_line => order_line.order)
    order_line: order_line[];
}
