class motorbike {
    customer_name = ""
    phone_number = ""
    bike_number = ""
    days = ""
    payment = ""
    get computed() {
        var response
        if (this.days <= 5) {
            return response = this.days * 500;
        } else if (this.days <= 10) {
            return response = (5 * 500) + ((this.days - 5) * 400);
        } else {
            return response = (5 * 500) + (5 * 400) + ((this.days - 10) * 100);
        }
    }
}
module.exports.motorbike = motorbike