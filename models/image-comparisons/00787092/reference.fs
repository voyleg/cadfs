FeatureScript 1511;
import(path : "onshape/std/geometry.fs", version : "1511.0");
import(path : "onshape/std/common.fs", version : "1511.0");
const mm = millimeter;
const VERTEX = EntityType.VERTEX;
const EDGE = EntityType.EDGE;
const FACE = EntityType.FACE;
const BODY = EntityType.BODY;
function v(x, y){return vector(x, y);}
function OD(order){return orderDisambiguation(order);}
function OSD(set){return originalSetDisambiguation(set);}
function TD(topology){return topologyDisambiguation(topology);}
function TDD(query){return trueDependencyDisambiguation(query);}
function sQuery(a, b, c) {return sketchEntityQuery(a, b, c);}

annotation { "Feature Type Name" : "Feature", "Feature Type Description" : "" }
export const myFeature = defineFeature(function(context is Context, id is Id, definition is map)
    precondition{}
    {
        {
            var Q0;
            Q0=qCreatedBy(makeId("Top.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E0", {"center": v(0, 0) * mm, "radius": 11 * mm});
            skCircle(sketch, "E1", {"center": v(0, 26.82) * mm, "radius": 11 * mm});
            skArc(sketch, "E2", {"start": v(11.18, 19.8) * mm, "mid": v(0.09, 40.02) * mm, "end": v(-11.27, 19.95) * mm});
            skArc(sketch, "E3.1.0", {"start": v(-22.74, -0.22) * mm, "mid": v(-34.7, -19.94) * mm, "end": v(-11.64, -19.73) * mm});
            skCircle(sketch, "E3.1.1", {"center": v(-23.23, -13.41) * mm, "radius": 11 * mm});
            skArc(sketch, "E3.2.0", {"start": v(11.56, -19.58) * mm, "mid": v(34.62, -20.09) * mm, "end": v(22.9, -0.22) * mm});
            skCircle(sketch, "E3.2.1", {"center": v(23.23, -13.41) * mm, "radius": 11 * mm});
            skArc(sketch, "E4", {"start": v(12.26, 21.92) * mm, "mid": v(11.53, 7.94) * mm, "end": v(22.9, -0.22) * mm});
            skArc(sketch, "E5.1.0", {"start": v(-25.11, -0.35) * mm, "mid": v(-12.64, 6.01) * mm, "end": v(-11.27, 19.95) * mm});
            skArc(sketch, "E5.2.0", {"start": v(12.86, -21.58) * mm, "mid": v(1.11, -13.96) * mm, "end": v(-11.64, -19.73) * mm});
            skArc(sketch, "E6.0", {"start": v(-22.62, 2.78) * mm, "mid": v(-37.31, -21.42) * mm, "end": v(-9, -21.17) * mm});
            skArc(sketch, "E7.0", {"start": v(-25.03, 2.65) * mm, "mid": v(-15.12, 7.7) * mm, "end": v(-14.03, 18.77) * mm});
            skArc(sketch, "E8.0", {"start": v(13.72, 18.2) * mm, "mid": v(0.1, 43.02) * mm, "end": v(-13.83, 18.38) * mm});
            skArc(sketch, "E9.0", {"start": v(14.81, 20.35) * mm, "mid": v(14.23, 9.24) * mm, "end": v(23.27, 2.76) * mm});
            skArc(sketch, "E10.0", {"start": v(8.9, -20.98) * mm, "mid": v(37.2, -21.6) * mm, "end": v(22.83, 2.78) * mm});
            skArc(sketch, "E11.0", {"start": v(10.22, -23) * mm, "mid": v(0.89, -16.95) * mm, "end": v(-9.24, -21.53) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0")}),-1.0]])]});
            var Q1;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E4");var subQ1=sQuery(id+"F0.wireOp",EDGE,"E2");var subQ2=makeQuery(id+"F0.imprint","INTERSECT",VERTEX,{"disambiguationData":[OD(0.0)],"derivedFrom":[subQ1,subQ0]});Q1=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"disambiguationData":[TD([[subQ2,-1.0]])],"derivedFrom":subQ1}),-1.0]])]});}
            var Q2;
            Q2=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E1")}),-1.0]])]});
            var Q3;
            Q3=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E3.1.1")}),-1.0]])]});
            var Q4;
            Q4=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E3.2.1")}),-1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4]), "endBound" : BoundingType.SYMMETRIC, "depth" : 6.5 * mm, "offsetDistance" : 25 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E7.0")])],"isStart":false});
            var Q1;
            Q1=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E11.0")])],"isStart":false});
            var Q2;
            Q2=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E9.0")])],"isStart":false});
            var Q3;
            Q3=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E8.0")])],"isStart":false});
            var Q4;
            Q4=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E10.0")])],"isStart":false});
            var Q5;
            Q5=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E6.0")])],"isStart":false});
            var Q6;
            Q6=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E11.0")])],"isStart":true});
            var Q7;
            Q7=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E7.0")])],"isStart":true});
            var Q8;
            Q8=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E9.0")])],"isStart":true});
            var Q9;
            Q9=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E10.0")])],"isStart":true});
            var Q10;
            Q10=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E6.0")])],"isStart":true});
            var Q11;
            Q11=makeQuery(id+"F1.opExtrude","CAP_EDGE",EDGE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E8.0")])],"isStart":true});
            fillet(context, id + "F2", {"entities" : qUnion([Q0, Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11]), "radius" : 2 * mm, "tangentPropagation" : true, "rho" : 0.5, "crossSection" : FilletCrossSection.CONIC, "allowEdgeOverflow" : false});
        }
    });