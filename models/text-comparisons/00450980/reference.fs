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
            Q0=qCreatedBy(makeId("Front.planeOp"),FACE);
            var sketch = newSketch(context, id + "F0", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E0", {"center": v(-25.22, 0) * mm, "radius": 3.3 * mm});
            skCircle(sketch, "E1", {"center": v(24.7, 0) * mm, "radius": 3.14 * mm});
            skArc(sketch, "E2", {"start": v(-31.44, 0) * mm, "mid": v(-25.3, -6.15) * mm, "end": v(-19.14, 0) * mm});
            skArc(sketch, "E3", {"start": v(19.06, 0) * mm, "mid": v(24.85, -5.79) * mm, "end": v(30.64, 0) * mm});
            skLineSegment(sketch, "E4", {"start": v(-31.44, 0) * mm, "end": v(-31.44, 15.23) * mm});
            skLineSegment(sketch, "E5", {"start": v(-31.44, 15.23) * mm, "end": v(-17.83, 15.23) * mm});
            skLineSegment(sketch, "E6", {"start": v(-17.83, 15.23) * mm, "end": v(-17.83, 6.05) * mm});
            skLineSegment(sketch, "E7", {"start": v(-17.83, 6.05) * mm, "end": v(18.27, 6.05) * mm});
            skLineSegment(sketch, "E8", {"start": v(18.27, 6.05) * mm, "end": v(18.27, 15.23) * mm});
            skLineSegment(sketch, "E9", {"start": v(18.27, 15.23) * mm, "end": v(30.64, 15.23) * mm});
            skLineSegment(sketch, "E10", {"start": v(30.64, 15.23) * mm, "end": v(30.64, 0) * mm});
            skLineSegment(sketch, "E11", {"start": v(19.06, 0) * mm, "end": v(-19.14, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F0",true);
            extrude(context, id + "F1", {"entities" : qUnion([Q0]), "depth" : 5 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F0.wireOp",EDGE,"E4")])]});
            var sketch = newSketch(context, id + "F2", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E12", {"start": v(1.84, 13.06) * mm, "end": v(1.84, 6.63) * mm});
            skLineSegment(sketch, "E13", {"start": v(1.84, 13.06) * mm, "end": v(3.34, 13.06) * mm});
            skLineSegment(sketch, "E14", {"start": v(3.34, 13.06) * mm, "end": v(5, 11.23) * mm});
            skLineSegment(sketch, "E15", {"start": v(1.84, 6.63) * mm, "end": v(3.34, 6.63) * mm});
            skLineSegment(sketch, "E16", {"start": v(3.34, 6.63) * mm, "end": v(5, 8.46) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=makeQuery(id+"F2.imprint","IMPRINT",FACE,{"disambiguationData":[TD([[makeQuery(id+"F2.imprint","IMPRINT",EDGE,{"derivedFrom":sQuery(id+"F2.wireOp",EDGE,"E12")}),1.0]])]});
            extrude(context, id + "F3", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "endBound" : BoundingType.THROUGH_ALL, "oppositeDirection" : true, "depth" : 25 * mm});
        }
        {
            var Q0;
            {var subQ0=sQuery(id+"F0.wireOp",EDGE,"E11");var subQ1=sQuery(id+"F0.wireOp",EDGE,"E10");var subQ2=sQuery(id+"F0.wireOp",EDGE,"E8");var subQ3=sQuery(id+"F0.wireOp",EDGE,"E7");var subQ4=sQuery(id+"F0.wireOp",EDGE,"E6");var subQ5=sQuery(id+"F0.wireOp",EDGE,"E4");var subQ6=sQuery(id+"F0.wireOp",EDGE,"E0");var subQ7=sQuery(id+"F0.wireOp",EDGE,"E3");var subQ8=sQuery(id+"F0.wireOp",EDGE,"E1");var subQ9=sQuery(id+"F0.wireOp",EDGE,"E2");Q0=makeQuery(id+"F3.boolean.opBoolean","SPLIT",FACE,{"disambiguationData":[TD([makeQuery(id+"F1.opExtrude","SWEPT_FACE",FACE,{"disambiguationData":[OSD([subQ6])]})])],"derivedFrom":makeQuery(id+"F1.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([subQ6,subQ8,subQ9,subQ7,subQ5,sQuery(id+"F0.wireOp",EDGE,"E5"),subQ4,subQ3,subQ2,sQuery(id+"F0.wireOp",EDGE,"E9"),subQ1,subQ0])],"isStart":false})});}
            var sketch = newSketch(context, id + "F4", { "sketchPlane" : qUnion([Q0])});
            skLineSegment(sketch, "E17.bottom", {"start": v(-6.87, 6.05) * mm, "end": v(6.9, 6.05) * mm});
            skLineSegment(sketch, "E17.top", {"start": v(-6.87, 0) * mm, "end": v(6.9, 0) * mm});
            skLineSegment(sketch, "E17.left", {"start": v(-6.87, 6.05) * mm, "end": v(-6.87, 0) * mm});
            skLineSegment(sketch, "E17.right", {"start": v(6.9, 6.05) * mm, "end": v(6.9, 0) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F4",true);
            extrude(context, id + "F5", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.ADD, "depth" : 2 * mm});
        }
        {
            var Q0;
            Q0=makeQuery(id+"F5.opExtrude","CAP_FACE",FACE,{"disambiguationData":[OSD([sQuery(id+"F4.wireOp",EDGE,"E17.bottom"),sQuery(id+"F4.wireOp",EDGE,"E17.top"),sQuery(id+"F4.wireOp",EDGE,"E17.left"),sQuery(id+"F4.wireOp",EDGE,"E17.right")])],"isStart":false});
            var sketch = newSketch(context, id + "F6", { "sketchPlane" : qUnion([Q0])});
            skCircle(sketch, "E18", {"center": v(3.77, 4.17) * mm, "radius": 1.45 * mm});
            skPoint(sketch, "E18.centerSnap0", {"position": v(6.9, 3.03) * mm});
            skPoint(sketch, "E18.centerSnap1", {"position": v(0.02, 6.05) * mm});
            skSolve(sketch);
        }
        {
            var Q0;
            Q0=qSketchRegion(id+"F6",true);
            extrude(context, id + "F7", {"entities" : qUnion([Q0]), "operationType" : NewBodyOperationType.REMOVE, "oppositeDirection" : true, "depth" : 25 * mm});
        }
    });