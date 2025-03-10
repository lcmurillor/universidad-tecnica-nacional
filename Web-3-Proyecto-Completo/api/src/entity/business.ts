import { IsNotEmpty, MaxLength, MinLength } from "class-validator";
import { Column, Entity, JoinColumn, ManyToOne, OneToMany, PrimaryGeneratedColumn, Unique } from "typeorm";
import { user } from "./user";
import { business_type } from "./business_type";
import { order } from "./order";
import { phone } from "./phone";
import { photo } from "./photo";
import { product } from "./product";

@Entity()
@Unique(['identity'])
export class business {
    @PrimaryGeneratedColumn()
    id: number;

    @Column() @IsNotEmpty() @MaxLength(20) @MinLength(9)
    identity: string;

    @Column() @IsNotEmpty() @MaxLength(100)
    name: string;

    @Column() @IsNotEmpty() @MaxLength(250)
    address: string;

    @Column() @IsNotEmpty() @MaxLength(10)
    open_time: string;

    @Column() @IsNotEmpty() @MaxLength(10)
    close_time: string;

    @Column() @IsNotEmpty() @MaxLength(1)
    status: string;

    @Column() @IsNotEmpty() 
    created_at: string;

    @Column() @IsNotEmpty() 
    updated_at: string;

    @ManyToOne(type => user, user => user.business)
    user: user;

    @ManyToOne(type => business_type, business_type => business_type.business)
    business_type: business_type;

    @OneToMany(type => phone, phone => phone.business)
    phone: phone[];

    @OneToMany(type => photo, photo => photo.business)
    photo: photo[];

    @OneToMany(type => order, order => order.business)
    order: order[];

    @OneToMany(type => product, product => product.business_delivery_id)
    product: product[];
}
