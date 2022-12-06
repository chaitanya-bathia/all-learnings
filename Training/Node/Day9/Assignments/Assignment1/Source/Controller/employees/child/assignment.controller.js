var express = require("express");
var EmployeeDomain = require("../../../Domain/controller.domain/employees.domain");
var router = express.Router({ mergeParams: true });

class AssignmentController {

  static async get(req, res) {
    const employeeDomain = new EmployeeDomain();
    employeeDomain.getAssignments(req, res);
  }
  static async getAnAssignment(req, res) {
    const employeeDomain = new EmployeeDomain();
    employeeDomain.getAnAssignment(req, res);
  }
  static async updateAnAssignment(req, res) {
    const employeeDomain = new EmployeeDomain();
    employeeDomain.updateAnAssignment(req, res);
  }
}

router.get("/", AssignmentController.get);
router.get("/:AssignmentId", AssignmentController.getAnAssignment);
router.put("/:AssignmentId", AssignmentController.updateAnAssignment);

module.exports = router;