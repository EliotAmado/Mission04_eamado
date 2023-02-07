$('#ButtonSend').click(function () {
    alert('From' + $('#FinalGradeAlph').val +
        ", Subject: " + $("#textSubjects").val +
        ", Message: " + $("#textMessage").val);

    $("#picEliot").fadeToggle()
})


//JavaScript Calculator
$('#calcButton').click(function () {
    var AssignmentsV = $('#Assignments').val() * .5
    var GroupProjectsV = $('#GroupProjects').val() * .1
    var QuizzesV = $('#Quizzes').val() * .1
    var MidtermExamV = $('#MidtermExam').val() * .1
    var FinalExamV = $('#FinalExam').val() * .1
    var IntexV = $('#Intex').val() * .1

    var FinalGradeNumeric = (AssignmentsV + GroupProjectsV + QuizzesV + MidtermExamV + FinalExamV + IntexV)
    var FinalGradeAlph = (AssignmentsV + GroupProjectsV + QuizzesV + MidtermExamV + FinalExamV + IntexV)
    if (FinalGradeNumeric >= 94) {
        FinalGradeAlph
        FinalGradeNumeric = 'A'
    }
    else if (FinalGradeNumeric < 94 && FinalGradeNumeric >= 90) {
        FinalGradeAlph
        FinalGradeNumeric = 'A-'
    }
    else if (FinalGradeNumeric < 90 && FinalGradeNumeric >= 87) {
        FinalGradeAlph
        FinalGradeNumeric = 'B+'
    }
    else if (FinalGradeNumeric < 87 && FinalGradeNumeric >= 84) {
        FinalGradeAlph
        FinalGradeNumeric = 'B'
    }
    else if (FinalGradeNumeric < 84 && FinalGradeNumeric >= 80) {
        FinalGradeAlph
        FinalGradeNumeric = 'B-'
    }
    else if (FinalGradeNumeric < 80 && FinalGradeNumeric >= 77) {
        FinalGradeAlph
        FinalGradeNumeric = 'C+'
    }
    else if (FinalGradeNumeric < 77 && FinalGradeNumeric >= 74) {
        FinalGradeAlph
        FinalGradeNumeric = 'C'
    }
    else if (FinalGradeNumeric < 74 && FinalGradeNumeric >= 70) {
        FinalGradeAlph
        FinalGradeNumeric = 'C-'
    }
    else if (FinalGradeNumeric < 70 && FinalGradeNumeric >= 67) {
        FinalGradeAlph
        FinalGradeNumeric = 'D+'
    }
    else if (FinalGradeNumeric < 67 && FinalGradeNumeric >= 64) {
        FinalGradeAlph
        FinalGradeNumeric = 'D'
    }
    else if (FinalGradeNumeric < 64 && FinalGradeNumeric >= 60) {
        FinalGradeAlph
        FinalGradeNumeric = 'D-'
    }
    else {
        FinalGradeAlph
        FinalGradeNumeric = 'E'
    }
    $('#FinalGradeNumeric').text(FinalGradeNumeric);
    $('#FinalGradeAlph').text(FinalGradeAlph);

    return false;
});
