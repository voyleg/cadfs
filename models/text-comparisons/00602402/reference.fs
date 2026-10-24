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
            skLineSegment(sketch, "E0.bottom", {"start": v(0, 0) * mm, "end": v(914.4, 0) * mm});
            skLineSegment(sketch, "E0.top", {"start": v(0, -609.6) * mm, "end": v(914.4, -609.6) * mm});
            skLineSegment(sketch, "E0.left", {"start": v(0, 0) * mm, "end": v(0, -609.6) * mm});
            skLineSegment(sketch, "E0.right", {"start": v(914.4, 0) * mm, "end": v(914.4, -609.6) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F0.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F0.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F0.wireOp",EDGE,"E0.bottom")}),-1.0]])]});
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 914.4 * mm, "offsetDistance" : 30.48 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top")])]});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E1.bottom", {"start": v(36.2, 876.56) * mm, "end": v(874.4, 876.56) * mm});
            skLineSegment(sketch, "E1.top", {"start": v(36.2, 725.95) * mm, "end": v(874.4, 725.95) * mm});
            skLineSegment(sketch, "E1.left", {"start": v(36.2, 876.56) * mm, "end": v(36.2, 725.95) * mm});
            skLineSegment(sketch, "E1.right", {"start": v(874.4, 876.56) * mm, "end": v(874.4, 725.95) * mm});
            skLineSegment(sketch, "E2.bottom", {"start": v(36.2, 691.02) * mm, "end": v(874.4, 691.02) * mm});
            skLineSegment(sketch, "E2.top", {"start": v(36.2, 529.5) * mm, "end": v(874.4, 529.5) * mm});
            skLineSegment(sketch, "E2.left", {"start": v(36.2, 691.02) * mm, "end": v(36.2, 529.5) * mm});
            skLineSegment(sketch, "E2.right", {"start": v(874.4, 691.02) * mm, "end": v(874.4, 529.5) * mm});
            skLineSegment(sketch, "E3.bottom", {"start": v(36.2, 484.65) * mm, "end": v(432.45, 484.65) * mm});
            skLineSegment(sketch, "E3.top", {"start": v(36.2, 27.45) * mm, "end": v(432.45, 27.45) * mm});
            skLineSegment(sketch, "E3.left", {"start": v(36.2, 484.65) * mm, "end": v(36.2, 27.45) * mm});
            skLineSegment(sketch, "E3.right", {"start": v(432.45, 484.65) * mm, "end": v(432.45, 27.45) * mm});
            skLineSegment(sketch, "E4.bottom", {"start": v(479.32, 484.65) * mm, "end": v(875.56, 484.65) * mm});
            skLineSegment(sketch, "E4.top", {"start": v(479.32, 27.45) * mm, "end": v(875.56, 27.45) * mm});
            skLineSegment(sketch, "E4.left", {"start": v(479.32, 484.65) * mm, "end": v(479.32, 27.45) * mm});
            skLineSegment(sketch, "E4.right", {"start": v(875.56, 484.65) * mm, "end": v(875.56, 27.45) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E1.bottom")}),-1.0]])]});
            var Q1;
            Q1=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E2.bottom")}),-1.0]])]});
            var Q2;
            Q2=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E3.bottom")}),-1.0]])]});
            var Q3;
            Q3=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E4.bottom")}),-1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0, Q1, Q2, Q3]), "operationType" : NewBodyOperationType.ADD, "depth" : 16.76 * mm, "offsetDistance" : 30.48 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E0.top")])]});
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E5.bottom", {"start": v(211.4, 846.36) * mm, "end": v(683.83, 846.36) * mm});
            skLineSegment(sketch, "E5.top", {"start": v(211.4, 828.78) * mm, "end": v(683.83, 828.78) * mm});
            skLineSegment(sketch, "E5.left", {"start": v(211.4, 846.36) * mm, "end": v(211.4, 828.78) * mm});
            skLineSegment(sketch, "E5.right", {"start": v(683.83, 846.36) * mm, "end": v(683.83, 828.78) * mm});
            skLineSegment(sketch, "E6.bottom", {"start": v(211.4, 670.57) * mm, "end": v(683.83, 670.57) * mm});
            skLineSegment(sketch, "E6.top", {"start": v(211.4, 655.19) * mm, "end": v(683.83, 655.19) * mm});
            skLineSegment(sketch, "E6.left", {"start": v(211.4, 670.57) * mm, "end": v(211.4, 655.19) * mm});
            skLineSegment(sketch, "E6.right", {"start": v(683.83, 670.57) * mm, "end": v(683.83, 655.19) * mm});
            skLineSegment(sketch, "E7.bottom", {"start": v(400.37, 365.48) * mm, "end": v(378.4, 365.48) * mm});
            skLineSegment(sketch, "E7.top", {"start": v(400.37, 167.36) * mm, "end": v(378.4, 167.36) * mm});
            skLineSegment(sketch, "E7.left", {"start": v(400.37, 365.48) * mm, "end": v(400.37, 167.36) * mm});
            skLineSegment(sketch, "E7.right", {"start": v(378.4, 365.48) * mm, "end": v(378.4, 167.36) * mm});
            skLineSegment(sketch, "E8.bottom", {"start": v(497.06, 365.48) * mm, "end": v(519.03, 365.48) * mm});
            skLineSegment(sketch, "E8.top", {"start": v(497.06, 167.36) * mm, "end": v(519.03, 167.36) * mm});
            skLineSegment(sketch, "E8.left", {"start": v(497.06, 365.48) * mm, "end": v(497.06, 167.36) * mm});
            skLineSegment(sketch, "E8.right", {"start": v(519.03, 365.48) * mm, "end": v(519.03, 167.36) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0 = qSketchRegion(id + "F4", true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 27.43 * mm, "offsetDistance" : 30.48 * mm});
        }
    });